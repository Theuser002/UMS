using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UMS.IRepository;
using UMS.Models;

namespace UMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveRequestController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<LeaveRequestController> _logger;
        private readonly IMapper _mapper;

        public LeaveRequestController(IUnitOfWork unitOfWork, ILogger<LeaveRequestController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        [Authorize]
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetLeaveRequests()
        {
            try
            {
                var leaveRequets = await _unitOfWork.LeaveRequests.GetAll();
                var results = _mapper.Map<IList<LeaveRequestDto>>(leaveRequets);
                return Ok(results);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in the {nameof(GetLeaveRequests)}");
                return StatusCode(500, "Internal Server Error. Please try again later.");
            }
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetLeaveRequest(int id)
        {
            try
            {
                var leaveRequet = await _unitOfWork.LeaveRequests.Get(e => e.Id == id);
                var result = _mapper.Map<LeaveRequestDto>(leaveRequet);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in the {nameof(GetLeaveRequests)}");
                return StatusCode(500, "Internal Server Error. Please try again later.");
            }
        }
    }
}
