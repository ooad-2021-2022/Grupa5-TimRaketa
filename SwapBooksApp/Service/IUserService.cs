using System.Security.Claims;

namespace SwapBooksApp.Service
{
    public interface IUserService
    {
        ClaimsPrincipal getUser();
        string getUserId();
    }
}