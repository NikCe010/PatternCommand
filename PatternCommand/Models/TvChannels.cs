using System.Collections.Generic;
using System.Linq;

namespace PatternCommand.Models
{
    /// <summary>
    /// Модель доступных каналов
    /// </summary>
    public class TvChannels
    {
        /// <summary>
        /// Список доступных каналов
        /// </summary>
        private List<ChannelModel> Channels { get; }
        
        /// <summary>
        /// Номер последнего канала
        /// </summary>
        private int LastChannelId { get; }
        
        /// <summary>
        /// Номер первого канала
        /// </summary>
        private int FirstChannelId { get; }
        
        /// <summary>
        /// Номер текущего канала
        /// </summary>
        private int CurrentChannelId { get; set; }
        
        /// <summary/>
        public TvChannels()
        {
            Channels = new List<ChannelModel>{
                new ChannelModel {Id = 1, Name = "Первый"},
                new ChannelModel {Id = 2, Name = "Россия 1"},
                new ChannelModel {Id = 3, Name = "Культура"},
                new ChannelModel {Id = 4, Name = "НТВ"},
                new ChannelModel {Id = 5, Name = "НикаТВ"},
                new ChannelModel {Id = 6, Name = "СТС"},
                new ChannelModel {Id = 7, Name = "Пятница"},
                new ChannelModel {Id = 8, Name = "ТНТ"},
                new ChannelModel {Id = 9, Name = "РенТВ"},
                new ChannelModel {Id = 10, Name = "ТВ3"}
            };
            LastChannelId = Channels.Last().Id;
            FirstChannelId = Channels.First().Id;
            CurrentChannelId = FirstChannelId;
        }

        /// <summary>
        /// Получение первого канала
        /// </summary>
        /// <returns></returns>
        public ChannelModel FirstChannel()
        {
            return Channels.First();
        }
        
        /// <summary>
        /// Получение следующего канала
        /// </summary>
        /// <returns></returns>
        public ChannelModel NextChannel()
        {
            if (CurrentChannelId < LastChannelId)
            {
                var updateChannel = ++CurrentChannelId;
                return Channels.FirstOrDefault(a => a.Id == updateChannel);
            }
            
            CurrentChannelId = FirstChannelId;
            return Channels.First();
        }
        
        /// <summary>
        /// Получение предыдущего канала
        /// </summary>
        /// <returns></returns>
        public ChannelModel PreviousChannel()
        {
            if (CurrentChannelId > FirstChannelId)
            {
                var updateChannel = --CurrentChannelId;
                return Channels.FirstOrDefault(a => a.Id == updateChannel);
            }
            
            CurrentChannelId = LastChannelId;
            return Channels.Last();
        }
    }
}