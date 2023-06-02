namespace CourseApp.HangfireBackgroundJobs.Managers.DelayedJobs
{
    public class UserLoginMessageManager
    {
        public void Process()
        {
            Console.WriteLine("Kullanıcı giriş yapalı 3 saniye oldu!");
        }
    }
}
