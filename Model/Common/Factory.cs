using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Common
{
    public abstract class Factory
    {
        public abstract Caserne CreateCaserne();
        public abstract Usine CreateUsine();
    }
}
