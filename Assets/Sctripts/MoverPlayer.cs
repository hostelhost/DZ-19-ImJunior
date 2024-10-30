using UnityEngine;

public class MoverPlayer : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private PlayerAnimatorData _playerAnimatorData;
    [SerializeField] private InputManager _inputManager;
    [SerializeField] private float _speed = 5.0f;

    private void Update()
    {
        ManageAnimator();

        transform.Translate(_inputManager._inputHorizontal * Time.deltaTime * _speed, _inputManager._inputVertical * Time.deltaTime * _speed, 0, Space.World);
    }

    private void ManageAnimator()
    {
        _animator.SetFloat(_playerAnimatorData.HorizonalAxisID, _inputManager._inputHorizontal);
        _animator.SetFloat(_playerAnimatorData.VerticalAxisID, _inputManager._inputVertical);
    }
}
