namespace CourseApp.HangfireBackgroundJobs.Managers.FireAndForgetJobs
{
    public class CourseAddCartAlert
    {
        public void Process(string name)
        {
            Console.WriteLine($"Kullanıcı sepete {name} ekledi.");
        }
    }
}
