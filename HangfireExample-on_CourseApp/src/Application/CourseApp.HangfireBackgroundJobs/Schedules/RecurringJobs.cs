using CourseApp.HangfireBackgroundJobs.Managers.RecurringJobs;
using Hangfire;

namespace CourseApp.HangfireBackgroundJobs.Schedules
{
    public static class RecurringJobs
    {
        public static void HappinessMessage()
        {
            RecurringJob.AddOrUpdate<HappinessMessageManager>("Biraz_mutluluk",job=>job.Process(),("0-59/10 * * * *"));
        }
    } 
}
