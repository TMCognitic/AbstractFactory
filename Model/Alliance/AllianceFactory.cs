using Model.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Alliance
{
    public class AllianceFactory : Factory
    {
        public override Caserne CreateCaserne()
        {
            return new AllianceCaserne();
        }

        public override Usine CreateUsine()
        {
            return new AllianceUsine();
        }
    }
}
