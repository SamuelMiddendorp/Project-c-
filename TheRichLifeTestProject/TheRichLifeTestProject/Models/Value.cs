using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TheRichLifeTestProject.Models
{
    public class Value
    {
        public int ValueId { get; set; }
        public string ValueValue { get; set; }
        public int AtributeId { get; set; }
        [ForeignKey("AtributeId")]
        public Atribute Atribute { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}
