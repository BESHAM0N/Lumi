using UnityEngine;
using Zenject;

namespace Lumi.Models
{
    public sealed class EntityFactory
    {
        private readonly GameObject _spawnPrefab;

        [Inject]
        public EntityFactory([Inject(Id = "SpawnPrefab")] GameObject spawnPrefab)
        {
            _spawnPrefab = spawnPrefab;
        }
        
        public Lumi CreateLumi()
        {
            var health = new Health();
            health.Initialize(5);

            var ability = new TeleportAbility(distance: 2f);

            return new Lumi(
                entityId: 1,
                health: health,
                ability: ability
            );
        }

        public Nuo CreateNuo()
        {
            var health = new Health();
            health.Initialize(3);

            var ability = new SpawnAbility(_spawnPrefab);

            return new Nuo(
                entityId: 2,
                health: health,
                ability: ability
            );
        }
    }
}