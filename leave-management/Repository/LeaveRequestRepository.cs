using leave_management.Contracts;
using leave_management.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Repository
{
    public class LeaveRequestRepository : ILeaveRequestRepository
    {
        private readonly ApplicationDbContext _db;
        public LeaveRequestRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool Create(LeaveRequest entity)
        {
            _db.LeaveRequests.Add(entity);
            return Save();
        }

        public bool Delete(LeaveRequest entity)
        {
            _db.LeaveRequests.Remove(entity);
            return Save();
        }

        public ICollection<LeaveRequest> FindAll()
        {

            var LeaveHistorys = _db.LeaveRequests
                .Include(q=>q.RequestingEmployee)
                .Include(q => q.ApprovedBy)
                .Include(q => q.LeaveType)
                .ToList();
            return LeaveHistorys;
        }

        public LeaveRequest FindById(int id)
        {
            var LeaveHistory = _db.LeaveRequests
                .Include(q => q.RequestingEmployee)
                .Include(q => q.ApprovedBy)
                .Include(q => q.LeaveType)
                .FirstOrDefault(q => q.Id == id);
            return LeaveHistory;
        }

        public ICollection<LeaveRequest> GetLeaveRequestsByEmployee(string employeeId)
        {
            var leaveRequets = FindAll()
                .Where(q => q.RequestingEmployeeId == employeeId)
                .ToList();
            return leaveRequets;

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

        public bool Update(LeaveRequest entity)
        {
            _db.LeaveRequests.Update(entity);
            return Save();
        }
    }
}
