using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeteriaAndRestaurant.DAL.Models
{
    public class CheckLoginDto
    {
        public CheckLoginDto()
        {
            IsSuccess = false;
            Permission = -1;
        }
        public Boolean IsSuccess { get; set; }
        public int Permission { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Message { get; set; }
    }
}
