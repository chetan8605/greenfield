using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Membership
{
    public interface IAuthService
    {
        bool Login(string username, string password);
        bool Register(string username, string password);    
        bool ForgotPassword(string username, string password);
        bool ResetPassword(string username, string OldPassword, String NewPassword);
    }
}
