using FluentValidation.Results;
using SysManager.Application.Contracts.Users.Request;
using SysManager.Application.Data.MySql.Repositories;
using SysManager.Application.Errors;
using SysManager.Application.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

//namespace SysManager.Application.Validators.user
//{
//    public class UserEmailValidation : IValidationRepository<UserPostRequest, UserRepository>
//    {
//        public ValidationFailure Validate(UserPostRequest contract, UserRepository repository)
//        {
//            var user = repository.GetUserByEmailAsync(contract.Email);

//            if (user.Result != null)
//                return new ValidationFailureCustom("UserEmail", SysManagerErrors.User_Put_BadRequest_Email_Cannot_Duplicate.Description());
//            return new ValidationFailureCustom();
//        }
        
//    }

//}

