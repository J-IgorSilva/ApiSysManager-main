using FluentValidation;
using SysManager.Application.Contracts.Users.Request;
using SysManager.Application.Errors;
using SysManager.Application.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SysManager.Application.Validators.user.Request
{
    public class UserPutRequestValidator : AbstractValidator<UserPutRequest>
    {
        public UserPutRequestValidator()
        {
            RuleFor(x => x.UserName)
            .Must(username => !string.IsNullOrEmpty(username))
            .WithMessage(SysManagerErrors.User_Put_BadRequest_UserName_Cannot_Be_Null_Or_Empty.Description());
            RuleFor(x => x.Email)
                .Must(email => !string.IsNullOrEmpty(email))
                .WithMessage(SysManagerErrors.User_Put_BadRequest_Email_Cannot_Be_Null_Or_Empty.Description());

            RuleFor(x => x.NewPassword)
                .Must(password => !string.IsNullOrEmpty(password))
                .WithMessage(SysManagerErrors.User_Put_BadRequest_Password_Cannot_Be_Null_Or_Empty.Description());
        }
    }
}
