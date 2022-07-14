using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations
{
    public class UcitajOdabraniRacun : SystemOperationsBase
    {
        public Racun Result { get; set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAllWithCondition(entity).Cast<Racun>().ToList()[0];
        }
    }
}
