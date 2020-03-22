using PatternCommand.Commands;
using PatternCommand.Models;

namespace PatternCommand
{
    class Program
    {
        static void Main(string[] args)
        {
            var channels = new TvChannels();
            ControlPanel controlPanel = new ControlPanel();
            TvModel tvModel = new TvModel(channels, new VolumeModel());
            
            controlPanel.SetCommand(new TurnOnTvCommand(tvModel));
            controlPanel.PressButton();
            
            controlPanel.SetCommand(new IncreaseVolumeCommand(tvModel));
            controlPanel.PressButton();
            controlPanel.PressButton();
            controlPanel.PressUndo();
            
            controlPanel.SetCommand(new NextChannelCommand(tvModel));
            controlPanel.PressUndo();
            controlPanel.PressUndo();
            controlPanel.PressButton();
            
            controlPanel.SetCommand(new TurnOnTvCommand(tvModel));
            controlPanel.PressUndo();
            
            controlPanel.SetCommand(new IncreaseVolumeCommand(tvModel));
            controlPanel.PressButton();
        }
    }
}