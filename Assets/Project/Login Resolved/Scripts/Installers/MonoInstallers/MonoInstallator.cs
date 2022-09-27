using UnityEngine;

namespace MVPLoginExample.Installers
{
    public class MonoInstallator : MonoInstaller
    {
        [Header("References")]
        [SerializeField] private MonoInstaller[] _monoInstallers;

        public override void Install()
        {
            foreach (var monoInstaller in _monoInstallers)
            {
                monoInstaller.Install();
            }
        }
    }
}