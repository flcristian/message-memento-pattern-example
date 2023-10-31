using message_memento_pattern_example.snapshot;

namespace message_memento_pattern_example.message;

public interface IMessage
{
    void SetText(string text);
    void SetColor(string color);
    ISnapshot CreateSnapshot();
    void SendMessage();
}