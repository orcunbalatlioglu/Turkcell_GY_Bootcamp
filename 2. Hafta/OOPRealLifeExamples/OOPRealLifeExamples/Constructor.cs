namespace OOPRealLifeExamples
{
    public class SunFlower
    {
        public bool IsBlack { get; set; }
        public int Weight { get; set; }

        public SunFlower() : this(false, 1){}
        public SunFlower(bool isBlack) : this(isBlack, 1){}
        public SunFlower(int weight) : this(false, weight) { }
        public SunFlower(bool isBlack, int weight)
        {
            Weight = weight;
            IsBlack = isBlack;
        }
    }
}
