using ScheduleManagement.Data;
using ScheduleManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleManagement.DAO
{
    public class ScheduleRepository
    {
        private readonly ApplicationDbContext _context;

        public ScheduleRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<ScheduleItem> GetAllSchedule()
        {
            return _context.ScheduleItems.ToList();
        }

        public ScheduleItem GetScheduleById(int id)
        {
            return _context.ScheduleItems.Find(id);
        }

        public void AddSchedule(ScheduleItem scheduleItem)
        {
            _context.ScheduleItems.Add(scheduleItem);
            _context.SaveChanges();
        }
        public void UpdateSchedule(ScheduleItem scheduleItem)
        {
            _context.ScheduleItems.Update(scheduleItem);
            _context.SaveChanges();
        }
        public void DeleteSchedule(int id)
        {
            var scheduleItem = _context.ScheduleItems.Find(id);
            if (scheduleItem != null)
            {
                _context.ScheduleItems.Remove(scheduleItem);
                _context.SaveChanges();
            }
        }
    }
}
