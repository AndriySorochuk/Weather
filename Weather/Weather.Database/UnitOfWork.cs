using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Database
{
    internal class UnitOfWork: IDisposable
    {
        private bool disposed = false;

        private readonly WeatherDBContext dbContext;
        private Dictionary<string, object> repositories;

        public UnitOfWork(WeatherDBContext dbContext)
        {
            this.dbContext = dbContext;
            this.repositories = new Dictionary<string, object>();
        }

        public IRepository<T>? Repository<T>() where T : class
        {
            if (repositories.Keys.Contains(typeof(T).ToString()) == true)
            {
                return repositories[typeof(T).ToString()] as IRepository<T>;
            }
            IRepository<T> repo = new Repository<T>(dbContext);
            repositories.Add(typeof(T).ToString(), repo);
            return repo;
        }

        public void Migrate()
        {
            dbContext.Database.Migrate();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    dbContext.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
