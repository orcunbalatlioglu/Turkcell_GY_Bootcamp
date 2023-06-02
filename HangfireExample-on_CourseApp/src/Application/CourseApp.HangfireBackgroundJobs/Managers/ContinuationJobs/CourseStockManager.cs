namespace CourseApp.HangfireBackgroundJobs.Managers.ContinuationJobs
{
    public class CourseStockManager
    {
        public void Process(string name, int quantity)
        {
            Console.WriteLine($"Stoktan {quantity} adet {name} düşüldü.");
        }
    }
}
