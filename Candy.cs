using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Candy_Stores.Data
{
    public class Candy
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string CName { get; set; }
        public string Ctype { get; set; }
        public int Cprice { get; set; }
       

        [ForeignKey(name:"CID")]
        public int CID{ get; set; }
    }
}
