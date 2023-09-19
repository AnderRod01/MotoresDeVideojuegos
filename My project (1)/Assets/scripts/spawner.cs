using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    [SerializeField] private prefabScriptableObject cuboSO;
    [SerializeField] private GameObject Cube;

    private float position = -9.0f;
    
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < cuboSO.numSpawns; i++)
        {
            SpawnCube();
        }
    }

    private void SpawnCube()
    {
        GameObject cubeSpawned = Instantiate(Cube, new Vector3(position, 0, 0), Quaternion.identity);
        position += 4.0f;
    }
}
