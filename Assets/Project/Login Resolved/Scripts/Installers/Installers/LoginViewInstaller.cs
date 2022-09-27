using MVPLoginExample.Presenters;
using MVPLoginExample.Views;
using UnityEngine;

namespace MVPLoginExample.Installers
{
    public class LoginViewInstaller : MonoInstallerGeneric<ILoginView>
    {
        [Header("References")]
        [SerializeField] private LoginView _loginView;

        protected override ILoginView GetInstalledClass()
        {
            return _loginView;
        }
    }
}