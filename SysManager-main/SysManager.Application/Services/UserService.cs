using SysManager.Application.Contracts.Users.Request;
using SysManager.Application.Helpers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SysManager.Application.Services
{
    public class UserService
    {
        public UserService()
        {
          
        }

        public async Task<ResultData> PostAsync(UserPostRequest request)
        {
            return new ResultData(true);
        }
    }
}
