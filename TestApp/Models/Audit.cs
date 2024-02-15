using System.ComponentModel.DataAnnotations;

namespace TestApp.Models
{
    public class Audit
    {
        public int Id { get; set; }
        public int queque_id { get; set; }
        public int status_id { get; set; }
        public int worker_id { get; set; }
        [DataType(DataType.Date)]
        public DateTime start_time{ get; set; }
        [DataType(DataType.Date)]
        public DateTime end_time{ get; set; }
    }
}
