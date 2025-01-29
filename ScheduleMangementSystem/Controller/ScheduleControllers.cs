using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScheduleManagement.Models;
using ScheduleManagement.Service;
namespace ScheduleManagement.Controllers
{
    public class ScheduleController
    {
        private readonly ScheduleService _scheduleService;

        public ScheduleController(ScheduleService scheduleService)
        {
            _scheduleService = scheduleService;
        }

        public List<ScheduleItem> GetAllSchedule()
        {
            return _scheduleService.GetAllSchedule();
        }

        public ScheduleItem GetScheduleById(int id)
        {
            return _scheduleService.GetScheduleById(id);
        }

        public void AddSchedule(string scheduleName, string scheduleRoom, string scheduleCourse)
        {
            var ScheduleItem = new ScheduleItem
            {
                ScheduleName = scheduleName,
                ScheduleRoom = scheduleRoom,
                ScheduleCourse = scheduleCourse,
                Date = DateTime.Now
            };
            _scheduleService.AddSchedule(ScheduleItem);
        }

        public void UpdateSchedule(int id, string scheduleName, string scheduleRoom, string scheduleCourse)
        {
            var scheduleItem = _scheduleService.GetScheduleById(id);
            if (scheduleItem != null)
            {
                scheduleItem.ScheduleName = scheduleName;
                scheduleItem.ScheduleRoom = scheduleRoom;
                scheduleItem.ScheduleCourse = scheduleCourse;
                scheduleItem.Date = DateTime.Now;
                _scheduleService.UpdateSchedule(scheduleItem);
            }
        }

        public void DeleteSchedule(int id)
        {
            _scheduleService.DeleteSchedule(id);
        }

        internal void AddSchedule(string scheduleName, object scheduleCourse, object room)
        {
            throw new NotImplementedException();
        }
    }
}

