namespace MVPLoginExample.Installers
{
    public abstract class MonoInstallerGeneric<TypeToInstall> : MonoInstaller
    {
        private TypeToInstall _typeToInstall;

        public TypeToInstall InstalledClass => _typeToInstall;

        public override void Install()
        {
            _typeToInstall = GetInstalledClass();
        }

        protected abstract TypeToInstall GetInstalledClass();
    }
}