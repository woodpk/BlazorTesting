using System;
using System.Collections.Generic;
using System.Text;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

namespace PhoenixCharts.Shared.Models
{
    //[Table("Consumer")]
    public class Consumer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //[DataType(DataType.Date)]
        //public DateTime DateBirth { get; set; }

        //public ICollection<Document> Documents { get; set; }

    }
}
