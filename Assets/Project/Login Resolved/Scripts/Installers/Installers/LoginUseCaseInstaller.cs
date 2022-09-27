using MVPLoginExample.Model.Entities;
using MVPLoginExample.Model.UseCases;
using UnityEngine;

namespace MVPLoginExample.Installers
{
    public class LoginUseCaseInstaller : MonoInstallerGeneric<ILoginUseCase>
    {
        [Header("References")]
        [SerializeField] private MonoInstallerGeneric<IService<UserLoginData>> _loginServiceInstaller;

        protected override ILoginUseCase GetInstalledClass()
        {
            IService<UserLoginData> loginService = _loginServiceInstaller.InstalledClass;

            return new LoginUseCase(loginService);
        }
    }
}