using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private HealthBar _healthBar;

    private float _addRemoveHealth = 10;
    private float _targetHealth;

    public void AddHealth()
    {
        int maxHealth = 100;

        if (_targetHealth + _addRemoveHealth <= maxHealth)
        {
            _targetHealth += _addRemoveHealth;
            _healthBar.ChangeHealth(_targetHealth);
        }
    }

    public void RemoveHealth()
    {
        int minHealth = 0;

        if (_targetHealth - _addRemoveHealth >= minHealth)
        {
            _targetHealth -= _addRemoveHealth;
            _healthBar.ChangeHealth(_targetHealth);
        }
    }
}
