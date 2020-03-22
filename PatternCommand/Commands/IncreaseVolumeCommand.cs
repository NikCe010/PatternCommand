using PatternCommand.Models;

namespace PatternCommand.Commands
{
    /// <summary>
    /// Команда увеличения громкости
    /// </summary>
    public class IncreaseVolumeCommand : Abstraction.ICommand
    {
        private readonly TvModel _tvModel;

        public IncreaseVolumeCommand(TvModel tvModel)
        {
            _tvModel = tvModel;
        }

        public void Execute()
        {
            _tvModel.IncreaseVolume();
        }

        public void Undo()
        {
            _tvModel.DecreaseVolume();
        }
    }
}