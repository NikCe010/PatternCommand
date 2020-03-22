using System;

namespace PatternCommand.Models
{
    /// <summary>
    /// Модель ТВ
    /// </summary>
    public class TvModel
    {
        private readonly TvChannels _channels;

        private readonly VolumeModel _volumeModel;

        private bool _isSwitchOff;

        public TvModel(TvChannels channels, VolumeModel volumeModel)
        {
            _channels = channels;
            _volumeModel = volumeModel;
            _isSwitchOff = true;
        }

        /// <summary>
        /// Включение
        /// </summary>
        public void On()
        {
            _isSwitchOff = false;
            Console.WriteLine("Телевизор включен.");
            Console.WriteLine("Текущий канал: " + _channels.FirstChannel().Name);
        }

        /// <summary>
        /// Выключение
        /// </summary>
        public void Off()
        {
            _isSwitchOff = true;
            Console.WriteLine("Телевизор выключен.");
        }

        /// <summary>
        /// Следующий канал
        /// </summary>
        public void NextChannel()
        {
            if (_isSwitchOff) return;
            var channel = _channels.NextChannel();
            Console.WriteLine("Текущий канал: " + channel.Name);
        }

        /// <summary>
        /// Предыдущий канал
        /// </summary>
        public void PreviousChannel()
        {
            if (_isSwitchOff) return;
            var channel = _channels.PreviousChannel();
            Console.WriteLine("Текущий канал: " + channel.Name);
        }

        /// <summary>
        /// Увеличение громкости
        /// </summary>
        public void IncreaseVolume()
        {
            if (_isSwitchOff) return;
            var volume = _volumeModel.IncreaseVolume();
            Console.WriteLine("Текущая громкость: " + volume);
        }

        /// <summary>
        /// Уменьшение громкости
        /// </summary>
        public void DecreaseVolume()
        {
            if (_isSwitchOff) return;
            var volume = _volumeModel.DecreaseVolume();
            Console.WriteLine("Текущая громкость: " + volume);
        }
    }
}