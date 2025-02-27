﻿using HR.LeaveManagement.BlazorUI.Models.LeaveAllocations;

namespace HR.LeaveManagement.BlazorUI.Models.LeaveRequests
{
    public class EmployeeLeaveRequestViewVM
    {
        public List<LeaveAllocationVM> LeaveAllocations { get; set; } = new();
        public List<LeaveRequestVM> LeaveRequests { get; set; } = new();
    }
}
