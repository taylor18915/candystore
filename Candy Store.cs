using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Candy_Stores.Data
{
    public class Candy_Store
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Location { get; set; }
        public string name { get; set; }
        public int ID { get; set; }
        public string State { get; set; }
        

    }
}
