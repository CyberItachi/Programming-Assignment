using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    [SerializeField] ObstacleData obstacleData;
    [SerializeField] GameObject obstaclePrefab;

    void Start()
    {
        GenerateObstacles();
    }

    void GenerateObstacles()
    {
        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                int index = x * 10 + y;
                if (obstacleData.obstacles[index])
                {
                    Vector3 position = new Vector3(x, 1f, y);
                    GameObject spawnedObstacle = Instantiate(obstaclePrefab, position, Quaternion.identity);
                    spawnedObstacle.transform.parent = transform;
                    spawnedObstacle.name = $"{obstacleData.name} {x} {y}";
                }
            }
        }
    }
}
