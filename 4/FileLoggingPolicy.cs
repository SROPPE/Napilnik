using System.IO;

namespace Homework4
{
    public class FileLoggingPolicy : ILoggingPolicy
    {
        private readonly string _path;

        public FileLoggingPolicy(string path)
        {
            _path = path;
        }

        public void Write(string message)
        {
            File.AppendAllText(_path, message);
        }
    }
}