using UnityEngine;

public class Player : MonoBehaviour
{
    private const int MaximumLifeForce = 100;
    private int LifeForce = MaximumLifeForce;

    public void ToAcceptLifeForce(int lifeForce)
    {
        if (MaximumLifeForce <= lifeForce + LifeForce)
            LifeForce = MaximumLifeForce;
        else
            LifeForce += lifeForce;
    }
}
