using System;
using System.Threading.Tasks;
using UMS.Data;
using UMS.IRepository;

namespace UMS.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private IGenericRepository<LeaveType> _leaveTypes;
        private IGenericRepository<LeaveStatus> _leaveStatus;
        private IGenericRepository<LeaveRequest> _leaveRequests;
        private IGenericRepository<LeaveAllocation> _leaveAllocations;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }

        public IGenericRepository<LeaveType> LeaveTypes => _leaveTypes ??= new GenericRepository<LeaveType>(_context);

        public IGenericRepository<LeaveStatus> LeaveStatus => _leaveStatus ??= new GenericRepository<LeaveStatus>(_context);

        public IGenericRepository<LeaveRequest> LeaveRequests => _leaveRequests ??= new GenericRepository<LeaveRequest>(_context);

        public IGenericRepository<LeaveAllocation> LeaveAllocations => _leaveAllocations ??= new GenericRepository<LeaveAllocation>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
