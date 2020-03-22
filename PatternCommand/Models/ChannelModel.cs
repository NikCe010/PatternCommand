namespace PatternCommand.Models
{
    /// <summary>
    /// Модель телевизионного канала
    /// </summary>
    public class ChannelModel
    {
        /// <summary>
        /// Номер канала
        /// </summary>
        public int Id { get; set; }
        
        /// <summary>
        /// Название канала
        /// </summary>
        public string Name { get; set; }
    }
}