using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaAndRestaurant.DAL.Models
{
    public class PrintDto
    {
        public string ProductName { get; set; }
        public int Amounts { get; set; }
        public float Price { get; set; }
        public float Sum { get; set; }
        public float Total { get; set; }
    }
}
