using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebYugiohCardApplication.Models
{
    public class ApiResponse
    {
        public ApiResponse()
        {
            data = new Card[0];
        }
        public Card[] data { get; set; }
    }
}
