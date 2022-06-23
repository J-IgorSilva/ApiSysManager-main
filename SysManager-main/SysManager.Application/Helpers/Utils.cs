using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace SysManager.Application.Helpers
{
    public static class Utils
    {
        public static ResultData<T> SuccessData<T>(T data)
        {
            var result = new ResultData<T>(data);
            result.Success = true;
            return result;
        }
        public static ResultData<T> ErrorData<T>(T data)
        {
            var result = new ResultData<T>(data);
            result.Success = false;
            return result;
        }

        public static IActionResult Convert(ResultData resultData)
        {
            if (resultData.Success)
                 return new ObjectResult(resultData) { StatusCode = (int)HttpStatusCode.OK};

            else return new BadRequestObjectResult(resultData);
        }
    }
}
