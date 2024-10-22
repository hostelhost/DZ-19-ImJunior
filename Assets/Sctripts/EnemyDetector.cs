using UnityEngine;

public class EnemyDetector : MonoBehaviour
{
    [SerializeField] private float detectionDistanceToTarget = 6f;
    [SerializeField] private Player _globalTarget;  

    public bool IsChasing { get; private set; }

    private void Update()
    {      
        if (Vector3.SqrMagnitude(transform.position - _globalTarget.transform.position) <= detectionDistanceToTarget * detectionDistanceToTarget)
            IsChasing = true;       
        else       
            IsChasing = false;     
    }

    public Vector3 GetGlobalTarget() =>  
         _globalTarget.transform.position;
    
}
