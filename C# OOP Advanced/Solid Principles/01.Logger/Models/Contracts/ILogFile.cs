namespace Logger.App.Models.Contracts
{
    public interface ILogFile
    {
        string Path { get; }

        int Size { get; }

        void Write(string messageLog);
    }
}
