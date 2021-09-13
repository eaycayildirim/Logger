
namespace nsILogLevel
{
    public interface ILogLevel
    {
        string Name { get; }

        void Write(string message);
    }
}
