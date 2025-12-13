using UnityEngine;

namespace Lumi.Models
{
    public class SpawnAbility : IAbility
    {
        public AbilityType AbilityType => AbilityType.Spawn;
        private readonly GameObject _prefab;

        private GameObject _spawnedObject;

        public SpawnAbility(GameObject prefab)
        {
            _prefab = prefab;
        }

        public void Use(AbilityContext context)
        {
            if (_prefab == null || context.Owner == null)
                return;

            if (_spawnedObject == null)
            {
                _spawnedObject =
                    Object.Instantiate(_prefab, context.Owner.position + Vector3.right, Quaternion.identity);
            }
            else
            {
                Object.Destroy(_spawnedObject);
                _spawnedObject = null;
            }
        }
    }
}