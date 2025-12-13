using Lumi.Models;
using Zenject;

namespace Lumi.Configs
{
    public class NuoInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IPlayerInput>().To<ArrowsInput>().AsSingle();
        }
    }
}