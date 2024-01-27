using UnityEngine;

public class ObjectSpawner2D : MonoBehaviour
{
    // Array to store manually assigned 2D objects
    public GameObject[] spawnedObjects;

    void Start()
    {
        // Spawn the objects and assign them manually in the Unity Editor
        SpawnObjects();

    }



    void SpawnObjects()
    {
        for (int i = 0; i < spawnedObjects.Length; i++)
        {
            Instantiate(spawnedObjects[i], new Vector2(0, -6), Quaternion.identity);
        }
    }
}