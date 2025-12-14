using Lumi.Models;
using UnityEngine;
using Zenject;

namespace Game.Scripts.App
{
    public sealed class GameInstaller : MonoInstaller
    {
        [Header("Abilities")]
        [SerializeField] private GameObject _spawnPrefab;
        
        public override void InstallBindings()
        {
            Container.Bind<EntityFactory>().AsSingle();
            
            Container.Bind<GameObject>()
                .WithId("SpawnPrefab")
                .FromInstance(_spawnPrefab)
                .AsSingle();
        }
    }
}