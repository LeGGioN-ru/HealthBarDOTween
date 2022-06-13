using UnityEngine;

public class HealthRemover : MonoBehaviour
{
    [SerializeField] private HealthBar _healthBar;

    public void Execute()
    {
        _healthBar.RemoveHealth();
    }
}
