
namespace DOP.Remoting
{
    public interface ILogger
    {
        void SetLevel(int level);
        void LogMessage(int level, string message);
    }
}
