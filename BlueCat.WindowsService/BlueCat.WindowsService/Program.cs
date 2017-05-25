using BlueCat.WindowsService.Service;
using System;
using System.IO;
using Topshelf;

namespace BlueCat.WindowsService
{
    class Program
    {
        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.ConfigureAndWatch(new FileInfo(AppDomain.CurrentDomain.BaseDirectory + "log4net.config"));

            HostFactory.Run(x => {
                x.UseLog4Net();
                x.Service<MainService>();
                x.SetDescription("BlueCat.WindowsService");//服务描述信息
                x.SetDisplayName("BlueCatWindowsService");//实际在service.msc里面显,属性--常规--显示名称
                x.SetServiceName("BlueCatWindowsService");//实际在service.msc服务，属性--常规--服务名称
                x.EnablePauseAndContinue();
            });
        }
    }
}
