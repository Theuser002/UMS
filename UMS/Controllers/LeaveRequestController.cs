using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UMS.Data;
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
        
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetLeaveRequests([FromQuery] RequestParams requestParams)
        {
            var leaveRequets = await _unitOfWork.LeaveRequests.GetAllPaged(requestParams, new List<string>{"LeaveType", "LeaveStatus"});
            var results = _mapper.Map<IList<LeaveRequestDto>>(leaveRequets);
            return Ok(results);
        }

        [HttpGet("{id:int}", Name = "GetLeaveRequest")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetLeaveRequest(int id)
        {
            var leaveRequet = await _unitOfWork.LeaveRequests.Get(e => e.Id == id);
            var result = _mapper.Map<LeaveRequestDto>(leaveRequet);
            return Ok(result);
        }

        [HttpPost]
        [Route("create")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateLeaveRequest([FromBody] CreateLeaveRequestDto leaveRequestDto)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in {nameof(CreateLeaveRequest)}");
                return BadRequest(ModelState);
            }

            var leaveRequest = _mapper.Map<LeaveRequest>(leaveRequestDto);
            leaveRequest.LeaveStatusId = 3;

            await _unitOfWork.LeaveRequests.Insert(leaveRequest);
            await _unitOfWork.Save();

            return CreatedAtRoute("GetLeaveRequest", new { id = leaveRequest.Id }, leaveRequest);
        }

        [Authorize(Roles = "Manager")]
        [HttpPatch]
        [Route("review")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ReviewLeaveRequest(int id, [FromBody] UpdateLeaveRequestDto leaveRequestDto)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(ReviewLeaveRequest)}");
                return BadRequest(ModelState);
            }

            var leaveRequest = await _unitOfWork.LeaveRequests.Get(x => x.Id == leaveRequestDto.Id);
            if (leaveRequest == null)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(ReviewLeaveRequest)}");
                return BadRequest("Submitted data is invalid.");
            }

            _mapper.Map(leaveRequestDto, leaveRequest);
            _unitOfWork.LeaveRequests.Update(leaveRequest);
            await _unitOfWork.Save();

            return NoContent();
        }
    }
}
