using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_TestApp.Models
{
    public class Services
    {
        [Key]
        public int ServiceId { get; set; }

        public string Service_Name { get; set; }
        public string Service_Discription { get; set; }
        public float Service_Coast { get; set; }
    }
}
