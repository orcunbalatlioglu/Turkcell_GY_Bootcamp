using CourseApp.HangfireBackgroundJobs.Managers.ContinuationJobs;
using Hangfire;

namespace CourseApp.HangfireBackgroundJobs.Schedules
{
    public static class ContinuationJobs
    {
        [AutomaticRetry(Attempts = 7)]
        public static void RemoveStock(string id, string name, int quantity) {
            BackgroundJob.ContinueJobWith<CourseStockManager>(
            parentId: id,
            job => job.Process(name,quantity)
            );
        }
    }
}
