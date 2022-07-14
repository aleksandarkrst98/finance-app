using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace SystemOperations
{
    public class VratiListuKorisnika : SystemOperationsBase
    {
        public List<Korisnik> Result { get; set; }
        protected override void ExecuteOperation(IEntity entity)
        {
            Result = repository.GetAll(new Korisnik()).Cast<Korisnik>().ToList();
        }
    }
}
