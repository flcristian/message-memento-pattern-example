using message_memento_pattern_example.message;
using message_memento_pattern_example.snapshot;

namespace message_memento_pattern_example.command;

public class Command : ICommand
{
    public IMessage Message { get; set; }
    public ISnapshot Backup { get; set; }

    public Command(IMessage message)
    {
        Message = message;
    }

    public void MakeBackup()
    {
        Backup = Message.CreateSnapshot();
    }

    public void Undo()
    {
        if (Backup != null)
        {
            Backup.Restore();
        }
    }
}