using PatternCommand.Abstraction;
using PatternCommand.Models;

namespace PatternCommand.Commands
{
    /// <summary>
    /// Команда включения ТВ
    /// </summary>
    public class TurnOnTvCommand : ICommand
    {
        private readonly TvModel _tvModel;
        
        public TurnOnTvCommand(TvModel tvModel)
        {
            _tvModel = tvModel;
        }
        
        public void Execute()
        {
            _tvModel.On();
        }

        public void Undo()
        {
            _tvModel.Off();
        }
    }
}