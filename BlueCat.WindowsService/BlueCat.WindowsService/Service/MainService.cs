using Quartz;
using Quartz.Impl;
using Topshelf;

namespace BlueCat.WindowsService.Service
{
    public sealed class MainService : ServiceControl, ServiceSuspend
    {
        private readonly IScheduler scheduler;

        public MainService()
        {
            this.scheduler = StdSchedulerFactory.GetDefaultScheduler();
        }

        public bool Start(HostControl hostControl)
        {
            scheduler.Start();
            return true;
        }

        public bool Stop(HostControl hostControl)
        {
            scheduler.Shutdown(false);
            return true;
        }

        public bool Continue(HostControl hostControl)
        {
            scheduler.ResumeAll();
            return true;
        }

        public bool Pause(HostControl hostControl)
        {
            scheduler.PauseAll();
            return true;
        }
    }
}
