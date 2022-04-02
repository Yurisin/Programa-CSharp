using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleEstoque1
{
[Table("produto", Schema = "public")]
    public class DtoProduto
    {
        [Key]

        public int id { get; set; }
        public string nome { get; set; }    
        public string categoria { get; set; }
        public string valor { get; set; }

    }
}