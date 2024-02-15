using System.ComponentModel.DataAnnotations;

namespace TestApp.Models
{
    public class Print_queque
    {
        public int Id{ get; set; }
        public int pq_uid { get; set; }
        [DataType(DataType.Date)]
        public DateTime pq_time { get; set; }
        public string? pq_document { get; set; }
    }
}
