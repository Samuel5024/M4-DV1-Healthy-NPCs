using UnityEngine;

public interface IHealth
{
    event System.Action<float> OnHPPctchanged;
    event System.Action OnDied;
    void TakeDamage(int amount);
}
