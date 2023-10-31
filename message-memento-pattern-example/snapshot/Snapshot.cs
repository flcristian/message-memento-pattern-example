using message_memento_pattern_example.message;

namespace message_memento_pattern_example.snapshot;

public class Snapshot : ISnapshot
{
    public IMessage Message { get; set; }
    public string Text { get; set; }
    public string Color { get; set; }

    public Snapshot(IMessage message, string text, string color)
    {
        Message = message;
        Text = text;
        Color = color;
    }

    public void Restore()
    {
        Message.SetText(Text);
        Message.SetColor(Color);
    }
}