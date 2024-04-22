using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using eUseControl.Domain.Entities.Blog;
using eUseControl.Domain.Entities.User;

namespace eUseControl.BusinessLogic.Interfaces
{
    public interface ISession
    {
        ULoginResp UserLogin(ULoginData data);
        URegisterResp UserRegister(URegisterData data);

        BlogListResp BlogList(bool isAdmin);

        BlogDetailsResp BlogDetails(int blogId);

        HttpCookie GenCookie(string loginCredential);
        UserMinimal GetUserByCookie(string apiCookieValue);
    }
}
