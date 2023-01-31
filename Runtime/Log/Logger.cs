using UnityEngine;

namespace RedBjorn.Utils
{
    public abstract class Logger : ILogger
    {
        public string Prefix;

        public void Init(string prefix, bool infoEnabled, bool warningEnabled, bool errorEnabled)
        {
            Prefix = prefix;
        }

        public void Info(object message)
        {
            Debug.Log(Prefix + message);
        }

        public void Warning(object message)
        {
            Debug.LogWarning(Prefix + message);
        }

        public void Error(object message)
        {
            Debug.LogError(Prefix + message);
        }
    }
}