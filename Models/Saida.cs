
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MercadoSantos.Models
{
    public class Saida
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public float Quantidade { get; set; }
        public float ValorDaVenda { get; set; }
        public DateTime Data { get; set; }
        public Venda Venda { get; set; }
    }
}