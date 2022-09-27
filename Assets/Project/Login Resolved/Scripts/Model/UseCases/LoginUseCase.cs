using MVPLoginExample.Model.Entities;

namespace MVPLoginExample.Model.UseCases
{
    public class LoginUseCase : ILoginUseCase
    {
        private readonly IService<UserLoginData> _loginService;

        public LoginUseCase(IService<UserLoginData> loginService)
        {
            _loginService = loginService;
        }

        public void Login(UserLoginData userLoginData)
        {
            _loginService.Send(userLoginData);
        }
    }
}