using PatternCommand.Abstraction;
using PatternCommand.Models;

namespace PatternCommand.Commands
{
    /// <summary>
    /// Команда переключения следующего канала
    /// </summary>
    public class NextChannelCommand : ICommand
    {
        private readonly TvModel _tvModel;

        public NextChannelCommand(TvModel tvModel)
        {
            _tvModel = tvModel;
        }

        public void Execute()
        {
            _tvModel.NextChannel();
        }

        public void Undo()
        {
            _tvModel.PreviousChannel();
        }
    }
}