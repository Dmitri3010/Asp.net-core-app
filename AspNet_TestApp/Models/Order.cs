using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_TestApp.Models
{
    public class Order
    {
            [Key]
            public int OrderId { get; set; }
            public string User { get; set; } 
            public string Address { get; set; } 
            public string ContactPhone { get; set; }

           [Required]
            public string Data { get; set; }
            public int ServiceId { get; set; }
            public Services Services { get; set; }

    }
}
