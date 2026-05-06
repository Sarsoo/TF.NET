using TF.MachineReadableUI;

namespace TF.Util;

public class MessageSet
{
    private readonly Lock _messageLock = new();
    private readonly Dictionary<string, List<FullMessage>> _messages = new();

    public virtual void Add(FullMessage message)
    {
        lock (_messageLock)
        {
            List<FullMessage> messages;
            if (!_messages.TryGetValue(message.Type, out messages!))
            {
                messages = new List<FullMessage>();
                _messages.Add(message.Type, messages);
            }

            messages.Add(message);
        }
    }

    public IEnumerable<FullMessage> Get(string type)
    {
        lock (_messageLock)
        {
            return _messages[type].ToArray();
        }
    }
}