using LeavedesignSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeavedesignSystem.Contracts
{
    interface ILeaveHistoryRepository: IRepositoryBase<LeaveHistory>
    {
       // ICollection<LeaveHistory> GetEmployeeByLeaveType(int id);
    }
}
