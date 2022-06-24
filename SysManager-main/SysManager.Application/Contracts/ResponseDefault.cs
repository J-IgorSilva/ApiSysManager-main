using System;
using System.Collections.Generic;
using System.Text;

namespace SysManager.Application.Contracts
{
    public class ResponseDefault
    {
        public ResponseDefault(string id, string menssage, bool hasErrors)
        {
            this.Id = id;
            this.Message = menssage;
            this.HasErros = hasErrors;

        }

        public string Id { get; set; }

        public string Message { get; set; }

        public bool HasErros { get; set; }

    }
}
