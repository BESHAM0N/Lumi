using Lumi.Models;
using Zenject;

namespace Lumi.Configs
{
    public sealed class LumiInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IPlayerInput>().To<WasdInput>().AsSingle();
        }
    }
}