using message_memento_pattern_example.command;
using message_memento_pattern_example.message;

internal class Program
{
    public static void Main(string[] args)
    {
        IMessage message = new Message("Hello world", "Red");
        ICommand command = new Command(message);
        command.MakeBackup();
        message.SetColor("Yellow");
        message.SendMessage();
        command.Undo();
        message.SendMessage();
    }
}