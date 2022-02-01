using System;
using System.Threading.Tasks;
using UMS.Data;

namespace UMS.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<LeaveType> LeaveTypes { get;  }
        IGenericRepository<LeaveStatus> LeaveStatus { get;  }
        IGenericRepository<LeaveRequest> LeaveRequests { get;  }
        IGenericRepository<LeaveAllocation> LeaveAllocations { get;  }
        Task Save();
    }
}
