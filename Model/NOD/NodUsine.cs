using Model.Common;

namespace Model.NOD
{
    public class NodUsine : Usine
    {
        public override Jeep CreateJeep()
        {
            return new NodJeep();
        }

        public override Moto CreateMoto()
        {
            return new NodMoto();
        }
    }
}