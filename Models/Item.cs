using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TestePaymentApi.Models
{
    public class Item
    {
        [Key()]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
    }
}