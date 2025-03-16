using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVA_Task_9.Models
{
    public class Sell
    {
        public int Id { get; set; }
        public int GoodId { get; set; }
        public Good Good { get; set; }
        public DateTime DateSell {get;set;}
        public int SellCount { get; set;}

    }
}
