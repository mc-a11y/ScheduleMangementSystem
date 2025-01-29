using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScheduleManagement.DAO;
using ScheduleManagement.Models;

namespace ScheduleManagement.Service
{
    public class ScheduleService
    {
        private readonly ScheduleRepository _scheduleRepository;
        public ScheduleService(ScheduleRepository scheduleRepository)
        {
            _scheduleRepository = scheduleRepository;
        }

        public List<ScheduleItem> GetAllSchedule()
        {
            return _scheduleRepository.GetAllSchedule();
        }
        public ScheduleItem GetScheduleById(int id)
        {
            return _scheduleRepository.GetScheduleById(id);
        }
        public void AddSchedule(ScheduleItem scheduleItem)
        {
            _scheduleRepository.AddSchedule(scheduleItem);
        }
        public void DeleteSchedule(int id)
        {
            _scheduleRepository.DeleteSchedule(id);
        }
        public void UpdateSchedule(ScheduleItem scheduleItem)
        {
            _scheduleRepository.UpdateSchedule(scheduleItem);
        }

    }
}

