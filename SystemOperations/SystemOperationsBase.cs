using Domain;
using Storage;
using Storage.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemOperations
{
    public abstract class SystemOperationsBase
    {
        protected IGenericRepository repository;

        //kako bi smanjili moguce nastale greske, svaka sistemska operacija ce odrediti svoje atribute
        //public object Result { get; protected set; }

        public SystemOperationsBase()
        {
            repository = new GenericRepository();
        }

        public void ExecuteTemplate(IEntity entity)
        {
            try
            {
                repository.OpenConnection();
                repository.BeginTransaction();
                ExecuteOperation(entity);
                repository.Commit();
            }
            catch (Exception)
            {
                repository.Rollback();
                throw;
            }
            finally { repository.CloseConnection(); }
        }

        protected abstract void ExecuteOperation(IEntity entity);
    }
}
