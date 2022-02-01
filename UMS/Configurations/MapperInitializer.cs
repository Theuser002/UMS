using AutoMapper;
using UMS.Data;
using UMS.Models;

namespace UMS.Configurations
{
    public class MapperInitializer : Profile
    {
        public MapperInitializer()
        {
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();
            CreateMap<LeaveRequest, CreateLeaveRequestDto>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
            CreateMap<LeaveType, CreateLeaveTypeDto>().ReverseMap();
            CreateMap<LeaveStatus, LeaveStatusDto>().ReverseMap();
            CreateMap<LeaveStatus, CreateLeaveStatusDto>().ReverseMap();
        }
    }
}
