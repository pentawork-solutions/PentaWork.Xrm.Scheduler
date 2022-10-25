namespace PentaWork.Xrm.SchedulerService.Contracts
{
    public interface ISchedulePluginLogger
    {
        void Trace(string message);
        void Info(string message);
        void Warn(string message);
        void Error(string message);
    }
}
