using UnityEngine;

public class AidKit : MonoBehaviour
{
    [SerializeField] private PlayerDetector _playerDetector;
    [SerializeField] private int LifeForce = 50;

    private void OnEnable()
    {
        _playerDetector.TookAidKit += TransferLifeForce;
    }

    private void OnDisable()
    {
        _playerDetector.TookAidKit -= TransferLifeForce;
    }

    private void TransferLifeForce(Player player)
    {
        player.ToAcceptLifeForce(LifeForce);
    }
}
