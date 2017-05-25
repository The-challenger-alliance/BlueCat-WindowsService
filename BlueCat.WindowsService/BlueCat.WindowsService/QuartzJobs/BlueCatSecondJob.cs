using log4net;
using Quartz;

namespace BlueCat.WindowsService.QuartzJobs
{
    public sealed class BlueCatSecondJob : IJob
    {
        private readonly ILog logger = LogManager.GetLogger(typeof(BlueCatSecondJob));

        public void Execute(IJobExecutionContext context)
        {
            this.logger.InfoFormat("Execute name is BlueCatSecondJob!");
        }
    }
}
