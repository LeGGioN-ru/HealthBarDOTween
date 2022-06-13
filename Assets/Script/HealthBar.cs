using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Slider _healthBar;
    [SerializeField] private float _changeDelay;
    [SerializeField] private Player _player;

    private Tweener _tweener;

    private void Start()
    {
        int defaultHealthValue = 0;
        _tweener = _healthBar.DOValue(defaultHealthValue, _changeDelay).SetAutoKill(false);
    }

    public void ChangeHealth()
    {
        _tweener.ChangeEndValue(_player.TargetHealth, true).Restart();
    }
}
