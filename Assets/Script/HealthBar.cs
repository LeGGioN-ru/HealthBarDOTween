using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthBar : MonoBehaviour
{
    [SerializeField] private float _changeDelay;

    private Slider _healthBar;
    private float _addRemoveHealth = 10;
    private float _targetHealth;
    private Tweener _tweener;

    public void AddHealth()
    {
        if (_targetHealth + _addRemoveHealth <= 100)
        {
            _targetHealth += _addRemoveHealth;
            _tweener.ChangeEndValue(_targetHealth, true).Restart();
        }
    }

    public void RemoveHealth()
    {
        if (_targetHealth - _addRemoveHealth >= 0)
        {
            _targetHealth -= _addRemoveHealth;
            _tweener.ChangeEndValue(_targetHealth, true).Restart();
        }
    }

    private void Start()
    {
        _healthBar = GetComponent<Slider>();
        _tweener = _healthBar.DOValue(_targetHealth, _changeDelay).SetAutoKill(false);
    }

    private void OnValidate()
    {
        float minDelay = 0.1f;

        if (_changeDelay <= 0)
        {
            _changeDelay = minDelay;
        }
    }
}
