using log4net;
using Quartz;

namespace BlueCat.WindowsService.QuartzJobs
{
    public sealed class BlueCatFirstJob : IJob
    {
        private readonly ILog logger = LogManager.GetLogger(typeof(BlueCatFirstJob));

        public void Execute(IJobExecutionContext context)
        {
            this.logger.InfoFormat("Execute name is BlueCatFirstJob!");
        }
    }
}
