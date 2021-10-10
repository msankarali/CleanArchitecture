using AutoMapper;
using Comp.HR.LeaveManagement.Application.DTOs;
using Comp.HR.LeaveManagement.Application.DTOs.LeaveRequest;
using Comp.HR.LeaveManagement.Domain;

namespace Comp.HR.LeaveManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();

            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();

            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
        }
    }
}