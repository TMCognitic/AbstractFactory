using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Common
{
    public abstract class VehiculeFactory
    {
        public abstract Moto CreateMoto();
        public abstract Jeep CreateJeep();
    }
}
