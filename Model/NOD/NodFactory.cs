using Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.NOD
{
    public class NodFactory : Factory
    {
        public override Caserne CreateCaserne()
        {
            return new NodCaserne();
        }

        public override Usine CreateUsine()
        {
            return new NodUsine();
        }
    }
}
