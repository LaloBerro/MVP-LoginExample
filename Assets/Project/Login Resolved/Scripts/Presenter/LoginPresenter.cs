using MVPLoginExample.Model.Entities;
using MVPLoginExample.Model.UseCases;

namespace MVPLoginExample.Presenters
{
    public class LoginPresenter
    {
        private readonly ILoginView _loginView;
        private readonly ILoginUseCase _loginUseCase;

        public LoginPresenter(ILoginView loginView, ILoginUseCase loginUseCase)
        {
            _loginView = loginView;
            _loginUseCase = loginUseCase;

            loginView.OnClickOnLogin += DoLogin;
        }

        private void DoLogin()
        {
            UserLoginData userLoginData = GetUserLoginData();

            _loginUseCase.Login(userLoginData);
        }

        public UserLoginData GetUserLoginData()
        {
            string username = _loginView.GetUsername();
            string password = _loginView.GetPassword();

            return new UserLoginData(username, password);
        }
    }
}