namespace message_memento_pattern_example.command;

public interface ICommand
{
    void MakeBackup();
    void Undo();
}