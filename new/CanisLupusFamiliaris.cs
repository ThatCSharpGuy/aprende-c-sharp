using System;

namespace Zoo
{
    public class CanisLupusFamiliaris : CanisLupus
    {
        public void MoverOrejas()
        {
            Console.WriteLine("Error: no tiene informaci�n sobre las orejas");
        }

        public virtual void Ladrar()
        {
            Console.WriteLine("Ladrido gen�rico");
        }
    }
}