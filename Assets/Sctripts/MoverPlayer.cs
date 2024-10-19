using UnityEngine;

public class MoverPlayer : MonoBehaviour
{
    private const string Horizontal = "Horizontal";
    private const string Vertical = "Vertical";

    [SerializeField] private Animator _animator;
    [SerializeField] private float _speed = 5.0f;

    private float _inputHorizontal;
    private float _inputVertical;

    private void Update()
    {
        _inputHorizontal = Input.GetAxisRaw(Horizontal);
        _inputVertical = Input.GetAxisRaw(Vertical);

        ManageAnimator();

        transform.Translate(_inputHorizontal * Time.deltaTime * _speed, _inputVertical * Time.deltaTime * _speed, 0, Space.World);
    }

    private void ManageAnimator()
    {
        _animator.SetFloat("horizonalAxis", _inputHorizontal);
        _animator.SetFloat("verticalAxis", _inputVertical);
    }
}