using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysManager.Application.Helpers
{
    public class ValidationFailureCustom : ValidationFailure
    {
        public ValidationFailureCustom(): base("","")
        {
            this.Haserrors = false;
        }
        public ValidationFailureCustom(string propertyName, string error) : base(propertyName, error)
        {
            this.Haserrors = true;
            base.ErrorCode = error;
        }
        public bool Haserrors { get; private set; }
    }
}
