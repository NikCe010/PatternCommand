namespace PatternCommand.Models
{
    /// <summary>
    /// Модель громкости
    /// </summary>
    public class VolumeModel
    {
        /// <summary>
        /// Текущая громкость
        /// </summary>
        private int CurrentVolume { get; set; }

        /// <summary>
        /// Максимальная громкость
        /// </summary>
        private int MaxVolume { get; }

        /// <summary>
        /// Минимальная громкость
        /// </summary>
        private int MinVolume { get; }
        
        /// <summary/>
        public VolumeModel()
        {
            MaxVolume = 100;
            MinVolume = 0;
        }

        /// <summary>
        /// Увеличение громкости
        /// </summary>
        /// <returns></returns>
        public int IncreaseVolume()
        {
            if (CurrentVolume != MaxVolume)
            {
                return ++CurrentVolume;
            }

            return CurrentVolume;
        }
        
        /// <summary>
        /// Уменьшение громкости
        /// </summary>
        /// <returns></returns>
        public int DecreaseVolume()
        {
            if (CurrentVolume != MinVolume)
            {
                return --CurrentVolume;
            }

            return CurrentVolume;
        }
    }
}