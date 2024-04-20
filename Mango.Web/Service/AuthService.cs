﻿using Mango.Web.Models;
using Mango.Web.Service.IService;
using Mango.Web.Utility;

namespace Mango.Web.Service
{
    public class AuthService : IAuthService
    {

        private readonly IBaseService _baseService;

        public AuthService(IBaseService baseService)
        {
            _baseService = baseService;
        }



        public async Task<ResponseDto?> AssignRoleAsync(RegisterationRequestDto RegisterationRequestDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Data = RegisterationRequestDto,
                Url = SD.AuthAPIBase + "/api/auth/AssignRole"

            });
        }

        public async Task<ResponseDto?> LoginAsync(LoginRequestDto loginRequestDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Data = loginRequestDto,
                Url = SD.AuthAPIBase + "/api/auth/Login"

            });
        }

        public async Task<ResponseDto?> RegisterAsync(RegisterationRequestDto RegisterationRequestDto)
        {
            return await _baseService.SendAsync(new RequestDto()
            {
                ApiType = SD.ApiType.POST,
                Data = RegisterationRequestDto,
                Url = SD.AuthAPIBase + "/api/auth/Register"

            });
        }
    }
}
