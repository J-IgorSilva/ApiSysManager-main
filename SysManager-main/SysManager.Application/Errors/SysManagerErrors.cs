using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace SysManager.Application.Errors
{
    public enum SysManagerErrors
    {
        [Description("É ncessário informar a propriedade UserName")]
        User_Post_BadRequest_UserName_Cannot_Be_Null_Or_Empty,

        [Description("É ncessário informar a propriedade Email")]
        User_Post_BadRequest_Email_Cannot_Be_Null_Or_Empty,

        [Description("É ncessário informar a propriedade Password")]
        User_Post_BadRequest_Password_Cannot_Be_Null_Or_Empty,

        [Description("Já existe um usuário com esse e-mail")]
        User_Post_BadRequest_Email_Cannot_Be_Duplicated,
        User_Put_BadRequest_UserName_Cannot_Be_Null_Or_Empty,
        User_Put_BadRequest_Email_Cannot_Be_Null_Or_Empty,
        User_Put_BadRequest_Password_Cannot_Be_Null_Or_Empty,
    }
}
