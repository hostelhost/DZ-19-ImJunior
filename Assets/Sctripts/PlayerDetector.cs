using System;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    [SerializeField] Player _player;

    public event Action<Player> TookAidKit;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<Gold>())
            Destroy(collision.gameObject);

        if (collision.GetComponent<AidKit>())
        {
            TookAidKit.Invoke(_player);
            Destroy(collision.gameObject);
        }
    }
}
