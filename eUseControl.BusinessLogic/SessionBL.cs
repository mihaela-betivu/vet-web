using System.Web;
using eUseControl.BusinessLogic.Core;
using eUseControl.BusinessLogic.Interfaces;
using eUseControl.Domain.Entities.Blog;
using eUseControl.Domain.Entities.User;

namespace eUseControl.BusinessLogic
{
    public class SessionBL : UserApi, ISession
    {
        public ULoginResp UserLogin(ULoginData data)
        {
            return ULoginAction(data);
        }
        public URegisterResp UserRegister(URegisterData data)
        {
            return URegisterAction(data);
        }
        public HttpCookie GenCookie(string loginCredential)
        {
            return Cookie(loginCredential);
        }
        public UserMinimal GetUserByCookie(string apiCookieValue)
        {
            return UserCookie(apiCookieValue);
        }
        public BlogListResp BlogList(bool isAdmin)
        {
            return BlogListAction(isAdmin);
        }
        public BlogDetailsResp BlogDetails(int blogId)
        {
            return BlogDetailsAction(blogId);
        }
    }
}
