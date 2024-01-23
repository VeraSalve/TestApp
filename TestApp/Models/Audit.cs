using System.ComponentModel.DataAnnotations;

namespace TestApp.Models
{
    public class Audit
    {
        public int Id { get; set; }
        public int Queque_id { get; set; }
        public int Worker_id { get; set; }
        [DataType(DataType.Date)]
        public DateTime Start_date { get; set; }
        [DataType(DataType.Date)]
        public DateTime End_date { get; set; }
    }
}
