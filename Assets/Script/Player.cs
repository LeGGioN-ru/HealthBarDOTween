using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public float TargetHealth { get; private set; }

    [SerializeField] private UnityEvent _healthChange;

    private float _addRemoveHealth = 10;

    public void AddHealth()
    {
        int maxHealth = 100;

        if (TargetHealth + _addRemoveHealth <= maxHealth)
        {
            TargetHealth += _addRemoveHealth;
            _healthChange.Invoke();
        }
    }

    public void RemoveHealth()
    {
        int minHealth = 0;

        if (TargetHealth - _addRemoveHealth >= minHealth)
        {
            TargetHealth -= _addRemoveHealth;
            _healthChange.Invoke();
        }
    }
}
