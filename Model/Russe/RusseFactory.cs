using Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Russe
{
    public class RusseFactory : Factory
    {
        public override Caserne CreateCaserne()
        {
            return new RusseCaserne();
        }

        public override Usine CreateUsine()
        {
            return new RusseUsine();
        }
    }
}
