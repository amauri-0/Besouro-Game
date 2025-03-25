using UnityEngine;

public class BeetleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject beetlePrefab;
    [SerializeField] private int numberOfBeetles = 10;

    private GameObject[] beetlesArray;

    void Start()
    {
        beetlesArray = new GameObject[numberOfBeetles];

        Camera cam = Camera.main;
        Vector2 lowerLeft = cam.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 upperRight = cam.ViewportToWorldPoint(new Vector2(1, 1));

        for (int i = 0; i < numberOfBeetles; i++)
        {
            float randomX = Random.Range(lowerLeft.x, upperRight.x);
            float randomY = Random.Range(lowerLeft.y, upperRight.y);
            Vector2 spawnPosition = new Vector2(randomX, randomY);

            GameObject newBeetle = Instantiate(beetlePrefab, spawnPosition, Quaternion.identity);
            beetlesArray[i] = newBeetle;
        }
    }
}
