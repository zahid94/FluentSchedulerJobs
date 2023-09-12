using FluentScheduler;
using FluentSchedulerJobs.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentSchedulerJobs
{
    public class JobRegistries : Registry
    {
        //find of allday of weeks
        private readonly DayOfWeek[] available = new DayOfWeek[] { DayOfWeek.Sunday, DayOfWeek.Monday, DayOfWeek.Tuesday, DayOfWeek.Wednesday, DayOfWeek.Thursday };

        public JobRegistries()
        {
            Schedule(() =>
            {
                if (available.Contains(DateTime.Now.DayOfWeek)) return new NewsLetterJob();
                else return null;
            }).ToRunNow().AndEvery(1).Minutes().Between(0,0,13,0);
        }
    }
}
