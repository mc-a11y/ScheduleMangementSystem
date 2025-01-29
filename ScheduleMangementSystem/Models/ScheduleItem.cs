using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScheduleManagement.Models;

namespace ScheduleManagement.Models
{
    public class ScheduleItem
    {
        [Key]
        public int Id { get; set; }
        public string ScheduleName { get; set; }
        public string ScheduleRoom { get; set; }
        public string ScheduleCourse { get; set; }
        public DateTime Date { get; set; }
    }
}



