using UnityEngine;

public class InputManager : MonoBehaviour
{
    private const string Horizontal = "Horizontal";
    private const string Vertical = "Vertical";

    public float _inputHorizontal { get; private set; }
    public float _inputVertical { get; private set; }

    private void Update()
    {
        _inputHorizontal = Input.GetAxisRaw(Horizontal);
        _inputVertical = Input.GetAxisRaw(Vertical);
    }
}
