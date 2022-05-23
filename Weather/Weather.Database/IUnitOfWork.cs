using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weather.Database
{
    public interface IUnitOfWork
    {
        IRepository<T>? Repository<T>() where T : class;
        void Migrate();

        //TODO: add transaction
    }
}
