using System.Collections;
using UnityEngine;
[RequireComponent(typeof(BoxCollider2D))]
public class EnemyAttacer : MonoBehaviour
{
    [SerializeField] private int _attack = 10;
    [SerializeField] private float _timeInterval = 1f;

    private Coroutine _coroutine;
    private WaitForSeconds _waitForSeconds;

    private void Awake()
    {
        _waitForSeconds = new WaitForSeconds(_timeInterval);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
            _coroutine = StartCoroutine(AttackEveryTimeInterval(player));
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
            StopCoroutine(_coroutine);
    }

    private IEnumerator AttackEveryTimeInterval(Player player)
    {
        while (player!= null)
        {
            player.TakeDamage(_attack);
            yield return _waitForSeconds;
        }
    }  
}
