namespace DependencyInversion
{
    internal interface ICarType
    {
        string Brand { get; set; }
        string Model { get; set; }
        string Description { get; set; }

        void PrintAllInfo();
    }

    public class Fuel : ICarType
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        string FuelType { get; set; }
        int FuelCapacity { get; set; }
        int RemainingFuel { get; set; }

        public Fuel() { }

        public void PrintAllInfo()
        {
            throw new NotImplementedException();
        }
    }

    public class Electric : ICarType
    {
        public string Brand { get ; set ; }
        public string Model { get ; set ; }
        public string Description { get ; set; }
        int BatteryCapacityKW { get; set; }
        int RemainingBattery { get; set; }
        
        public Electric() { }

        public void PrintAllInfo()
        {
            throw new NotImplementedException();
        }
    }

    public class Hybrid : ICarType
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        int BatteryCapacityKW { get; set; }
        int RemainingBattery { get; set; }
        string FuelType { get; set; }
        int FuelCapacity { get; set; }
        int RemainingFuel { get; set; }

        public Hybrid() { }

        public void PrintAllInfo()
        {
            throw new NotImplementedException();
        }
    }
}
