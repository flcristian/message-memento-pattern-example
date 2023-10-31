using message_memento_pattern_example.snapshot;

namespace message_memento_pattern_example.message;

public class Message : IMessage
{
    public string Text { get; set; }
    public string Color { get; set; }

    public Message(string text, string color)
    {
        Text = text;
        Color = color;
    }

    public void SetText(string text)
    {
        Text = text;
    }

    public void SetColor(string color)
    {
        Color = color;
    }

    public ISnapshot CreateSnapshot()
    {
        return new Snapshot(this, Text, Color);
    }

    public void SendMessage()
    {
        ConsoleColor color;
        
        if (Enum.TryParse(Color, out color))
        {
            Console.ForegroundColor = color;
            Console.WriteLine(Text);
            Console.ForegroundColor = ConsoleColor.White;
        }
        else
        {
            Console.WriteLine(Text);
        }
    }
}