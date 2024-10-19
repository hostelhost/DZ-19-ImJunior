using UnityEngine;

public class MoverEnemy : MonoBehaviour
{
    [SerializeField] private Point[] _targets;
    [SerializeField] private float _speed = 3f;

    private Vector3 _target;
    private int _currentIndexOfTarget;

    private void Start()
    {
        _currentIndexOfTarget = _targets.Length - 1;
        _target = NextTarget();
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, _target, _speed * Time.deltaTime);

        if (Vector2.SqrMagnitude(transform.position - _target) == 0 * 0)
            _target = NextTarget();
    }

    private Vector3 NextTarget()
    {
        _currentIndexOfTarget = ++_currentIndexOfTarget % _targets.Length;
        return _targets[_currentIndexOfTarget].transform.position;
    }
}
