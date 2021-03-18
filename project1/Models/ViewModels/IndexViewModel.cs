using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project1.Models.ViewModels
{
    public class IndexViewModel
    {
        public Project Projects { get; set; }
        public TourTimes TourTime { get; set; }
        public string Time { get; set; }
    }
}
