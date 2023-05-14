using System.Collections.Generic;
using System.Linq;
using TasksOrderVert1000.Context;
using TasksOrderVert1000.Model;

namespace TasksOrderVert1000.Repository
{
    public class DutyRepository
    {
        private readonly Context.Context _context;

        public DutyRepository(Context.Context context)
        {
            _context = context;
        }

        public IEnumerable<Tip> GetTips()
        {
            return _context.Tips.ToList();
        }

        public Tip GetTip(int id)
        {
            return _context.Tips.FirstOrDefault(d => d.TipId == id);
        }

        public void AddTip(Tip tip)
        {
            _context.Tips.Add(tip);
            _context.SaveChanges();
        }

        public void UpdateTip(int id, Tip tip)
        {
            var existingDuty = _context.Tips.FirstOrDefault(d => d.TipId == id);

            if (existingDuty != null)
            {
                existingDuty.TipName = tip.TipName;
                existingDuty.Description = tip.Description;
                existingDuty.Date = tip.Date;
                existingDuty.Major = tip.Major;

                _context.SaveChanges();
            }
        }


        public void DeleteTip(int id)
        {
            var duty = _context.Tips.FirstOrDefault(d => d.TipId == id);
            if (duty != null)
            {
                _context.Tips.Remove(duty);
                _context.SaveChanges();
            }
        }
    }
}