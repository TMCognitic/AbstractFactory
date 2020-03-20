using Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Alliance
{
    public class AllianceUsine : Usine
    {
        public override Jeep CreateJeep()
        {
            return new AllianceJeep();
        }

        public override Moto CreateMoto()
        {
            return new AllianceMoto();
        }
    }
}
