using UnityEngine;

public class Enemy : MonoBehaviour, ITakingDamage
{
    private const int MaximumLifeForce = 200;
    private int LifeForce = MaximumLifeForce;

    public void TakeDamage(int damage)
    {
        LifeForce -= damage;
        Debug.Log("Жизненная сила Enemy" + LifeForce);
        IsAlive();
    }

    private void IsAlive()
    {
        if (0 >= LifeForce)
            Destroy(gameObject);
    }
}
