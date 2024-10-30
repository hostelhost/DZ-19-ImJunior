using UnityEngine;

public class Enemy : MonoBehaviour, ITakingDamage
{
    [SerializeField] private int _lifeForce = 200;

    public void TakeDamage(int damage)
    {
        _lifeForce -= damage;
        Debug.Log("Жизненная сила Enemy" + _lifeForce);
        IsAlive();
    }

    private void IsAlive()
    {
        if (0 >= _lifeForce)
            Destroy(gameObject);
    }
}
