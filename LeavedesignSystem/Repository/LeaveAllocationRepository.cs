using LeavedesignSystem.Contracts;
using LeavedesignSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeavedesignSystem.Repository
{
    public class LeaveAllocationRepository : ILeaveAllocationRepository
    {

        private readonly ApplicationDbContext _db;

        public LeaveAllocationRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool Create(LeaveAlllocation entity)
        {
            _db.LeaveAllocations.Add(entity);
            return Save();

        }

        public bool Delete(LeaveAlllocation entity)
        {
            _db.LeaveAllocations.Remove(entity);
            return Save();
        }

        public ICollection<LeaveAlllocation> FindAll()
        {
            var LeaveAllocations = _db.LeaveAllocations.ToList();
            return LeaveAllocations;

        }

        public LeaveAlllocation FindById(int id)
        {
            var LeaveAllocations = _db.LeaveAllocations.Find(id);
            return LeaveAllocations;
        }

        public ICollection<LeaveAlllocation> GetEmployeeByLeaveAllocations(int id)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {

            var changes = _db.SaveChanges();
            return changes > 0;

        }

        public bool Update(LeaveAlllocation entity)
        {
            _db.LeaveAllocations.Update(entity);
            return Save();
        }
    }
}
