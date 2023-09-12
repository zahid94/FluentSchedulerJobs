using FluentScheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentSchedulerJobs.Jobs
{
    public class NewsLetterJob : IJob
    {
        public async void Execute()
        {
            //Write your code here every execution
            // code here ...
            await Console.Out.WriteLineAsync("News letter jobs execution");
        }
    }
}
