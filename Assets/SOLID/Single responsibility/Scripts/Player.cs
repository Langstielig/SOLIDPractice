using UnityEngine;

public class Player : MonoBehaviour
{
    private Movement playerMovement;
    private InputSystem inputSystem;
    private CollectPoints collectPoints;

    private bool isWin = false;

    private void Start()
    {
        playerMovement = GetComponent<Movement>();
        inputSystem = GetComponent<InputSystem>();
        collectPoints = GetComponent<CollectPoints>();
    }

    private void Update()
    {
        Move();
        CheckMaxCountOfPoints();
    }

    private void Move()
    {
        float horizontalInput = inputSystem.HorizontalInput();
        float verticalInput = inputSystem.VerticalInput();

        if(horizontalInput != 0.0f || verticalInput != 0.0f)
        {
            playerMovement.Move(new Vector3 (horizontalInput, 0, verticalInput));
        }
    }

    private void CheckMaxCountOfPoints()
    {
        if(collectPoints.CountOfPoints == collectPoints.MaxCountOfPounts && !isWin)
        {
            isWin = true;
            Debug.Log("You win!");
        }
    }
}
