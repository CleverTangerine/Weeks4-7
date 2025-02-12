using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{
    public GameObject Prefab;
    public List<GameObject> moonRocks;
    int spawnCount = 8;
    // Start is called before the first frame update
    void Start()
    {
        moonRocks = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < spawnCount; i++)
        {

        }
    }
}
