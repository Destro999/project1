using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace project1.Models
{
    public class Project
    {
        [Key]
        public int GroupId { get; set; }
        public string GroupName { get; set; }
        public int GroupSize { get; set; }
        public string EmailAddress { get; set; }
        public long? PhoneNumber { get; set; }

    }


}
