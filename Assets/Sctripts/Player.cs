using UnityEngine;

public class Player : MonoBehaviour, ITakingDamage
{
    private const int MaximumLifeForce = 100;
    private int LifeForce = MaximumLifeForce;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out ICollectable collectable))
        {
            if (collectable is Gold gold)
                gold.Execute();

            if (collectable is AidKit aidKit)           
                TryToAcceptLifeForce(aidKit.Execute());            
        }         
    }

    public void TakeDamage(int damage)
    {
        LifeForce -= damage;
        Debug.Log("Жизненная сила Player" + LifeForce);
        IsAlive();       
    }

    private void TryToAcceptLifeForce(int lifeForce)
    {
        if (MaximumLifeForce <= lifeForce + LifeForce)
            LifeForce = MaximumLifeForce;
        else
            LifeForce += lifeForce;
    }

    private void IsAlive()
    {
        if (0 >= LifeForce)
            Destroy(gameObject);
    }
}
