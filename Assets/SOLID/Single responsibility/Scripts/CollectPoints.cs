using UnityEngine;

public class CollectPoints : MonoBehaviour
{
    private int countOfPoints = 0;
    public int CountOfPoints { get {  return countOfPoints; } }

    [SerializeField] private int maxCountOfPoints;

    public int MaxCountOfPounts {  get { return maxCountOfPoints; } }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Collectible")
        {
            Destroy(other.gameObject);
            countOfPoints++;
        }
    }
}
