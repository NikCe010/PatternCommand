namespace PatternCommand.Abstraction
{
    /// <summary>
    /// Интерфейс команды
    /// </summary>
    public interface ICommand
    {
        void Execute();

        void Undo();
    }
}