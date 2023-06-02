using CourseApp.HangfireBackgroundJobs.Managers.DelayedJobs;
using Hangfire;

namespace CourseApp.HangfireBackgroundJobs.Schedules
{
    public static class DelayedJobs
    {
        public static void LoginMessage()
        {
            BackgroundJob.Schedule<UserLoginMessageManager>(
                job => job.Process(),
                TimeSpan.FromSeconds(3)
            );
        }
    }
}
