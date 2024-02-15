using Microsoft.CodeAnalysis.CSharp.Syntax;
using TestApp.Data;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
//using MyAspTest.Domain;

namespace TestApp.Models
{
    public class DataWorkerQueque
    {
        //public static List<Status_of_print> GetStatusOfPrint(int id)
        //{
        //    using (TestAppContext db = new TestAppContext())
        //    {
        //        List<Status_of_print> statuses = (from );
        //        return statuses;
        //    }

        //}

        public static List<Status_of_print> GetAllStatuses()
        {
            using (TestAppContext db = new TestAppContext())

            {
                var result = db.Print_Status.ToList();
                return result;
            }

        }

        public static List<Workers> GetAllWorkers()
        {
            using (TestAppContext db = new TestAppContext ())
            {
                var result = db.Worker.OrderBy(u => u.Id).ToList();
                return result;
            }
        }




    }
}
