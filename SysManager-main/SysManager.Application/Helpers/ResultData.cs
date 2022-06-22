using System;
using System.Collections.Generic;
using System.Text;

namespace SysManager.Application.Helpers
{
    public class ResultData
    {
        public ResultData(bool success)
        {

        }
        public bool Success { get; set; }
    }
    public class ResultData<T> : ResultData
    {
        public ResultData(T data): base(true)
        {
            this.Data = data;
        }
        public T Data { get; set; }
    }
}
