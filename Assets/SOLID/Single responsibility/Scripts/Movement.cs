using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float movingSpeed;

    public void Move(Vector3 movement)
    {
        transform.Translate(movement * movingSpeed * Time.deltaTime);
    }
}
