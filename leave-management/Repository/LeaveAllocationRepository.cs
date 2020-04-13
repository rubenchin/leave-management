using leave_management.Contracts;
using leave_management.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Repository
{
    public class LeaveAllocationRepository : ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext _db;
        public LeaveAllocationRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool CheckAllocation(int leavetypeid, string Employeeid)
        {
            var period = DateTime.Now.Year;
            return FindAll()
                .Where(q => q.EmployeeId == Employeeid && q.LeaveTypeId == leavetypeid && q.Period == period)
                .Any();
                }

        public bool Create(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Add(entity);
            return Save();
        }

        public bool Delete(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Remove(entity);
            return Save();
        }

        public ICollection<LeaveAllocation> FindAll()
        {
            var LeaveAllocations = _db.LeaveAllocations.Include(q=>q.LeaveType).Include(q=>q.Employee).ToList();
            return LeaveAllocations;
        }

        public LeaveAllocation FindById(int id)
        {
            var LeaveAllocation = _db.LeaveAllocations.Include(q=>q.LeaveType).Include(q=>q.Employee).FirstOrDefault(q=>q.Id==id);
            return LeaveAllocation;
        }

        public ICollection<LeaveAllocation> GetLeaveAllocationsByEmployee(string employeeId)
        {
            var period = DateTime.Now.Year;
            return FindAll().Where(q => q.EmployeeId == employeeId && q.Period==period).ToList();
         }

        public LeaveAllocation GetLeaveAllocationsByEmployeeAndType(string employeeId, int leaveTypeId)
        {
            var period = DateTime.Now.Year;
            return FindAll().FirstOrDefault(q => q.EmployeeId == employeeId && q.Period == period && q.LeaveTypeId == leaveTypeId);  
        }

        public bool isExist(int id)
        {
            var exist = _db.LeaveTypes.Any(q => q.Id == id);
            return exist;
        }

        public bool Save()
        {
            return _db.SaveChanges() > 0;
        }

        public bool Update(LeaveAllocation entity)
        {
            _db.LeaveAllocations.Update(entity);
            return Save();
        }
    }
}
