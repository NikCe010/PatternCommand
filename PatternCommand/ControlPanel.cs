using PatternCommand.Abstraction;

namespace PatternCommand
{
    /// <summary>
    /// Обработчик команд (пульт ТВ)
    /// </summary>
    public class ControlPanel
    {
        private ICommand _command;

        public void SetCommand(ICommand command)
        {
            _command = command;
        }
 
        public void PressButton()
        {
            _command.Execute();
        }
        
        public void PressUndo()
        {
            _command.Undo();
        }
    }
}