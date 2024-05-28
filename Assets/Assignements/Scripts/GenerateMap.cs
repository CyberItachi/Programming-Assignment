using UnityEngine;

public class GenerateMap : MonoBehaviour
{
    [SerializeField] int _mapHeight = 10;
    [SerializeField] int _mapWidth = 10;

    [SerializeField] GameObject _block;

    private void Awake()
    {
        GenerateGrid();
    }

    void GenerateGrid()
    {
        for (int x = 0; x < _mapWidth; x++)
        {
            for (int y = 0; y < _mapHeight; y++)
            {
                GameObject spawnedBlock = Instantiate(_block, new Vector3((float)x,0f,(float)y), Quaternion.identity);
                spawnedBlock.name = $"Ground {x} {y}";
                spawnedBlock.GetComponent<GroundInfo>().SetGroundInfo(x,y);
                spawnedBlock.transform.parent = transform;
            }
        }
    }
}
