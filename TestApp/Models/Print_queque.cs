using System.ComponentModel.DataAnnotations;

namespace TestApp.Models
{
    public class Print_queque
    {
        public int Id { get; set; }
        public int UID { get; set; }
        [DataType(DataType.Date)]
        public DateTime Time { get; set; }
        public string? Document { get; set; }
    }
}
