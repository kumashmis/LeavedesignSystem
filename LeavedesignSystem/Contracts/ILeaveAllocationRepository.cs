using LeavedesignSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeavedesignSystem.Contracts
{
    interface ILeaveAllocationRepository: IRepositoryBase<LeaveAlllocation>
    {
        //ICollection<LeaveAlllocation> GetEmployeeByLeaveType(int id);
    }
}
