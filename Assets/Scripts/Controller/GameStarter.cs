using Asteroids.Abstract_Factory;
using Asteroids.Object_Pool;
using UnityEngine;

namespace Asteroids
{
    internal sealed class GameStarter : MonoBehaviour
    {
        [System.Obsolete]
        private void Start()
        {
            var platform = new PlatformFactory().Create(Application.platform);
            Enemy.CreateAsteroidEnemy(new Health(100.0f, 100.0f));
            IEnemyFactory factory = new AsteroidFactory();
            factory.Create(new Health(100.0f, 100.0f));
            Enemy.Factory = factory;
            Enemy.Factory.Create(new Health(100.0f, 100.0f));
            EnemyPool enemyPool = new EnemyPool(5);
            var enemy = enemyPool.GetEnemy("Asteroid");
            enemy.transform.position = Vector3.one;
            enemy.gameObject.SetActive(true);
        }

    }
}
