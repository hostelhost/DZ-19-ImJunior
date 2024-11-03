using UnityEngine;

public class Player : MonoBehaviour, ITakingDamage
{
    private const int MaximumLifeForce = 100;

    private int _coinCount;
    private int _lifeForce = MaximumLifeForce;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out ICollectable collectable))
        {
            if (collectable is Gold gold)
                TakeCoin(gold.Execute());
            else if (collectable is AidKit aidKit)
                TryToAcceptLifeForce(aidKit.Execute());            
        }         
    }

    public void TakeDamage(int damage)
    {
        _lifeForce -= damage;
        Debug.Log("Жизненная сила Player" + _lifeForce);
        IsAlive();       
    }

    private void TakeCoin(int coin)
    {
        _coinCount += coin;
    }

    private void TryToAcceptLifeForce(int lifeForce)
    {
        if (MaximumLifeForce <= lifeForce + _lifeForce)
            _lifeForce = MaximumLifeForce;
        else
            _lifeForce += lifeForce;
    }

    private void IsAlive()
    {
        if (0 >= _lifeForce)
            Destroy(gameObject);
    }
}
