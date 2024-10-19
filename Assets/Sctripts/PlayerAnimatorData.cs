using UnityEngine;

public class PlayerAnimatorData : MonoBehaviour
{
    private const string HorizonalAxis = "horizonalAxis";
    private const string VerticalAxis = "verticalAxis";

    [SerializeField] private Animator _animator;

    public readonly int horizonalAxisID = Animator.StringToHash(HorizonalAxis);
    public readonly int verticalAxisID = Animator.StringToHash(VerticalAxis);
}
