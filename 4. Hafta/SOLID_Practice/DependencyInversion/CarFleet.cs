namespace DependencyInversion
{
    internal class CarFleet 
    {
        List<ICarType> Cars { get; set; }

        public Fleet(List<ICarType> cars)
        {
            Cars = cars;
        }

        public void AddCar() { }
        public void RemoveCar() { }
    }
}
