using MVPLoginExample.Model.Entities;
using MVPLoginExample.Model.Gateways;
using MVPLoginExample.Model.UseCases;

namespace MVPLoginExample.Installers
{
    public class MockLoginServiceInstaller : MonoInstallerGeneric<IService<UserLoginData>>
    {
        protected override IService<UserLoginData> GetInstalledClass()
        {
            return new MockLoginService();
        }
    }
}