using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using UMS.Data;
using UMS.Models;
using UMS.Services;

namespace UMS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<ApiUser> _userManager;
        private readonly ILogger<AccountController> _logger;
        private readonly IMapper _mapper;
        private readonly IAuthManager _authManager;

        public AccountController(UserManager<ApiUser> userManager,
            ILogger<AccountController> logger, 
            IMapper mapper, 
            IAuthManager authManager)
        {
            _userManager = userManager;
            _logger = logger;
            _mapper = mapper;
            _authManager = authManager;
        }

        [Authorize(Roles = "Administrator")]
        [HttpPost]
        [Route("register")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Register([FromBody] CreateUserDto createUserDto)
        {
            _logger.LogInformation($"Registration attempt for {createUserDto.Email}");

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var newUser = _mapper.Map<ApiUser>(createUserDto);
            newUser.UserName = createUserDto.Email;
            var createUser = await _userManager.CreateAsync(newUser, createUserDto.Password);

            if (!createUser.Succeeded)
            {
                foreach (var error in createUser.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }
                return BadRequest(ModelState);
            }

            await _userManager.AddToRoleAsync(newUser, createUserDto.Role);
              
            return Accepted();
        }

        [HttpPost]
        [Route("login")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Login([FromBody] LoginUserDto loginUserDto)
        {
            _logger.LogInformation($"Login attempt for {loginUserDto.Email}");

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if(!await _authManager.ValidateUser(loginUserDto))
            {
                return Unauthorized();
            }

            return Accepted(new { Token = await _authManager.CreateToken() });
        }
    } 
}
