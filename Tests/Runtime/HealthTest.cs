using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using TeaGames.Unity.GameplayFramework.Runtime;

namespace TeaGames.Unity.GameplayFramework.RuntimeTests
{
    public class HealthTest
    {
        private int _maxInt = int.MaxValue;
        private int _minInt = int.MinValue;
        
        [UnityTest]
        public IEnumerator HealthAdd()
        {
            for (var i = -200; i <= 200; i++)
                CheckHealthValue(i);

            CheckHealthValue(int.MinValue);
            CheckHealthValue(int.MaxValue);
            CheckHealthValue(_maxInt + 1000);
            CheckHealthValue(_maxInt + 1);
            CheckHealthValue(_minInt - 1000);
            CheckHealthValue(_minInt - 1);

            yield return new WaitForEndOfFrame();
        }

        private static void CheckHealthValue(int damage)
        {
            var gameObject = new GameObject();
            var health = gameObject.AddComponent<Health>();

            var healthBeforeDamage = health.Value;
            health.ApplyDamage(damage);
            
            Assert.IsTrue(health.Value <= healthBeforeDamage);
            Assert.IsTrue(health.Value >= 0 && health.Value <= health.MaxValue);
        }
    }
}
