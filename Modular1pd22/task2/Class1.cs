using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class MessagePublisher
    {
        public event Action<string> OnMessageSent;

        public void Send(string message)
        {
            OnMessageSent?.Invoke(message);
        }
    }
}
