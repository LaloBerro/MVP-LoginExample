using UnityEngine;

namespace MVPLoginExample.Installers
{
    public class MonoInstallerInitializer : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] private MonoInstaller _monoInstaller;

        private void Awake()
        {
            _monoInstaller.Install();
        }
    }
}