using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations
{
    public class VratiListuTipovaTransakcija : SystemOperationsBase
    {
        public List<TipTransakcije> Result { get; set; }

        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAll(new TipTransakcije()).Cast<TipTransakcije>().ToList();
        }
    }
}
