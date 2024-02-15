using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using TestApp.Models;

namespace TestApp.ViewModel
{
    public class QuequeViewModel
    {
        public int Id { get; set; }
        public int Worker_id { get; set; }
        public string Worker_name { get; set; } 

        public DateTime DateOfPrint { get; set; }
        public string DocName { get; set; }

    }

   // public Worker Worker_id => Workers.
}
