using HR.LeaveManagement.BlazorUI.Contracts;
using HR.LeaveManagement.BlazorUI.Models.LeaveTypes;
using HR.LeaveManagement.BlazorUI.Services.Base;

namespace HR.LeaveManagement.BlazorUI.Services
{
    public class LeaveTypeService : BaseHttpService, ILeaveTypeService
    {
        public LeaveTypeService(IClient client) : base(client)
        {
        }

        public Task<Response<Guid>> CreateLeaveType(LeaveTypeVM leaveType)
        {
            throw new NotImplementedException();
        }

        public Task<Response<Guid>> DeleteLeaveType(int id)
        {
            throw new NotImplementedException();
        }

        public Task<LeaveTypeVM> GetLeaveTypeDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<LeaveTypeVM>> GetLeaveTypes()
        {
            throw new NotImplementedException();
        }

        public Task<Response<Guid>> UpdateLeaveType(int id, LeaveTypeVM leaveType)
        {
            throw new NotImplementedException();
        }
    }
}
