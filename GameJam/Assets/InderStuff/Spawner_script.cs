using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Spawner_script : MonoBehaviour
{

    public GameObject square;
    public Vector2 spawnPosition;
    public bool position;
 
    // Start is called before the first frame update
    void Start()
    {
        SpawnObject();
            
    }

    void SpawnObject() {

        GameObject spawnedObject = Instantiate(square, spawnPosition, Quaternion.identity);
        position = true;
    }

}
