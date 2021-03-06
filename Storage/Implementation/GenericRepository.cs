using DatabaseBroker;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage.Implementation
{
    public class GenericRepository : IGenericRepository
    {
        private DBBroker broker = new DBBroker();

        public void BeginTransaction()
        {
            broker.BeginTransaction();
        }

        public void CloseConnection()
        {
            broker.CloseConnection();
        }

        public void Commit()
        {
            broker.Commit();
        }

        public void Delete(IEntity entity)
        {
            broker.Delete(entity);
        }

        public List<IEntity> GetAll(IEntity entity)
        {
            return broker.GetAll(entity);
        }

        public List<IEntity> GetAllWithCondition(IEntity entity)
        {
            return broker.GetAllWithCondition(entity);
        }

        public int GetNewId(IEntity entity)
        {
            return broker.GetNewID(entity);
        }

        public void OpenConnection()
        {
            broker.OpenConnection();
        }

        public void Rollback()
        {
            broker.Rollback();
        }

        public void Save(IEntity entity)
        {
            broker.Save(entity);
        }

        public void Update(IEntity entity)
        {
            broker.Update(entity);
        }
    }
}
