using UnityEngine;

public class InputSystem : MonoBehaviour
{
    public float HorizontalInput()
    {
        return Input.GetAxis("Horizontal");
    }

    public float VerticalInput()
    {
        return Input.GetAxis("Vertical");
    }
}
