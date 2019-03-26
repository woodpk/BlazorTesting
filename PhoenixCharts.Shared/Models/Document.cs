using System;
using System.Collections.Generic;
using System.Text;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

namespace PhoenixCharts.Shared.Models
{
    //[Table("Document")]
    public class Document
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int ConsumerID { get; set; }
        public Consumer Consumer { get; set; }


    }
}
