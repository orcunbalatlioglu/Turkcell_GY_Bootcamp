using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseApp.HangfireBackgroundJobs.Managers.FireAndForgetJobs
{
    internal class InvalidAccesAlert
    {
        public void Process()
        {
            Console.WriteLine("Yetkisiz bir kullanıcı sayfaya erişmeye çalıştı.");
        }
    }
}
