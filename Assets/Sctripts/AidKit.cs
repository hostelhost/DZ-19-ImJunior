using UnityEngine;

public class AidKit : MonoBehaviour
{
    [SerializeField] private int LifeForce = 25;

    public int TransferLifeForce()
    {
        Destroy(gameObject);
        return LifeForce;
    }
}
