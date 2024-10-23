using UnityEngine;
[RequireComponent(typeof(CircleCollider2D))]
public class EnemyDetector : MonoBehaviour
{
    private Vector3 _prosecuted;
    
    public bool IsChasing { get; private set; }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player prosecuted))
        {
            IsChasing = true;
            _prosecuted = prosecuted.transform.position;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Player>())        
            IsChasing = false;        
    }

    public Vector3 GetGlobalTarget() =>
         _prosecuted;  
}
