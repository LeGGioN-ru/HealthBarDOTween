using UnityEngine;

public class HealthAdder : MonoBehaviour
{
    [SerializeField] private HealthBar _healthBar;

    public void Execute()
    {
        _healthBar.AddHealth();
    }
}
