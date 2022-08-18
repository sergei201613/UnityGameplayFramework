using UnityEngine;
using UnityEngine.Events;

namespace TeaGames.Unity.GameplayFramework.Runtime
{
    public class Health : MonoBehaviour
    {
        [SerializeField] private int value = 100;
        [SerializeField] private int maxValue = 100;
        [SerializeField] private UnityEvent<DamageEvent> damagedEvent = new();
        [SerializeField] private UnityEvent diedEvent = new();

        public event System.Action<DamageEvent> Damaged;
        public event System.Action Died;

        public int Value => value;
        public int MaxValue => maxValue;

        public void ApplyDamage(int val)
        {
            if (val <= 0)
                return;

            value = Mathf.Clamp(value - val, 0, maxValue);

            DamageEvent damageData = new(value);
            
            Damaged?.Invoke(damageData);
            damagedEvent.Invoke(damageData);

            if (value == 0)
            {
                Died?.Invoke();
                diedEvent.Invoke();
            }
        }
    }

    public readonly struct DamageEvent
    {
        public readonly int Health;

        public DamageEvent(int health)
        {
            Health = health;
        }
    }
}
