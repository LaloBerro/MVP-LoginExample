using MVPLoginExample.Model.UseCases;
using MVPLoginExample.Presenters;
using UnityEngine;

namespace MVPLoginExample.Installers
{
    public class LoginPresenterInstaller : MonoInstallerGeneric<LoginPresenter>
    {
        [Header("References")]
        [SerializeField] private MonoInstallerGeneric<ILoginView> _loginViewInstaller;
        [SerializeField] private MonoInstallerGeneric<ILoginUseCase> _loginUseCaseInstaller;

        protected override LoginPresenter GetInstalledClass()
        {
            ILoginView loginView = _loginViewInstaller.InstalledClass;
            ILoginUseCase loginUseCase = _loginUseCaseInstaller.InstalledClass;

            return new LoginPresenter(loginView, loginUseCase);
        }
    }
}