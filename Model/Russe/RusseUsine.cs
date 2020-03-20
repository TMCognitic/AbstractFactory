using Model.Common;

namespace Model.Russe
{
    public class RusseUsine : Usine
    {
        public override Jeep CreateJeep()
        {
            return new RusseJeep();
        }

        public override Moto CreateMoto()
        {
            return new RusseMoto();
        }
    }
}