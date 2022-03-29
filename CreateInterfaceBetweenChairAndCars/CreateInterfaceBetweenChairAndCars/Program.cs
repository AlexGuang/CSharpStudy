using System;

namespace CreateInterfaceBetweenChairAndCars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chair whiteChair = new Chair("white", "wood");
            Chair brownChair = new Chair("brown", "plastic");
            Car damagedCar = new Car(139.00, "red");

            damagedCar.DestructableNearby.Add(whiteChair);
            damagedCar.DestructableNearby.Add(brownChair);

            damagedCar.Destroy();
        }
    }
}
