using CourseApp.HangfireBackgroundJobs.Managers.FireAndForgetJobs;
using Hangfire;

namespace CourseApp.HangfireBackgroundJobs.Schedules
{
    public static class FireAndForgetJobs {
        public static string CourseAdd(string name) {
            return BackgroundJob.Enqueue<CourseAddCartAlert>(job => job.Process(name));
        }

        public static void InvalidAccessTry() {
            BackgroundJob.Enqueue<InvalidAccesAlert>(job => job.Process());
        }
    }
}

