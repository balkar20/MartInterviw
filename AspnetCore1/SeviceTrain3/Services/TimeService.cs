namespace SeviceTrain3.Services
{
    public interface ITimer
    {
        string Time { get; }
    }
    public class Timer : ITimer
    {
        public Timer()
        {
            Time = System.DateTime.Now.ToString("hh:mm:ss");
        }
        public string Time { get; }
    }
    public class TimeService
    {
        private ITimer _timer;
        public TimeService(ITimer timer)
        {
            _timer = timer;
        }
        public string GetTime()
        {
            return _timer.Time;
        }
    }
}