using System;
using System.Runtime.CompilerServices;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Player : MonoBehaviour
{
    private const int MaximumLifeForce = 100;
    private int LifeForce = MaximumLifeForce;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Gold>())
            Destroy(collision.gameObject);
        
        if (collision.TryGetComponent<AidKit>(out AidKit adiKit))        
            TryToAcceptLifeForce(adiKit.TransferLifeForce());    
    }

    public void TakeDamage(int damage)
    {
        LifeForce -= damage;
        Debug.Log("Жизненная сила"+ LifeForce);
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
