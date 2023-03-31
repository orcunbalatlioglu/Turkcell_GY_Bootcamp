namespace DependencyInversion
{
    internal class CarFleet 
    {
        List<ICarType> Cars { get; set; }

        public CarFleet(List<ICarType> cars)
        {
            Cars = cars;
        }

        public void AddCar() { }
        public void RemoveCar() { }
    }
}
