using Microsoft.AspNetCore.Http;
using SwapBooksApp.Models;
using System.Security.Claims;

namespace SwapBooksApp.Service
{
    public class UserService : IUserService
    {

        private readonly IHttpContextAccessor httpContext;

        public UserService(IHttpContextAccessor httpContext)
        {
            this.httpContext = httpContext;
        }

        public string getUserId()
        {
            return httpContext.HttpContext.User?.FindFirstValue(ClaimTypes.NameIdentifier);
        }
        public ClaimsPrincipal getUser()
        {
            return httpContext.HttpContext?.User;
        }
    }
}
