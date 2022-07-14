using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations
{
    public class UcitajOdabranuTransakciju : SystemOperationsBase
    {
        public Transakcija Result { get; set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAllWithCondition(entity).Cast<Transakcija>().ToList()[0];
        }
    }
}
