using MVPLoginExample.Model.Entities;

namespace MVPLoginExample.Model.UseCases
{
    public interface ILoginUseCase
    {
        void Login(UserLoginData userLoginData);
    }
}