using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public GameObject[] animalPrefabsRight;
    public GameObject[] animalPrefabsLeft;
    private float spawnRangeX = 20;
    private float spawnRangeZ = 20;
    private float spawnPosZ = 30;
    private float StartDelay = 1.0f;
    private float spawnInterval = 1.0f;
    private float xRange = 19;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 2.0f , 1.5f);
        InvokeRepeating("SpawnRandomAnimalLeft", 2.0f , 1.5f);
        InvokeRepeating("SpawnRandomAnimalRight", 2.0f , 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
       
            //Randomly generate animal index spawn position//
            
     }
    
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-20, 20), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }

    void SpawnRandomAnimalLeft()
    {
        int animalIndex = Random.Range(0, animalPrefabsLeft.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-20, 20), 0, spawnPosZ);
        Instantiate(animalPrefabsLeft[animalIndex], spawnPos,animalPrefabsLeft[animalIndex].transform.rotation);
    }

 void SpawnRandomAnimalRight()
    {
        int animalIndex = Random.Range(0, animalPrefabsRight.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-20, 20), 0, spawnPosZ);
        Instantiate(animalPrefabsRight[animalIndex], spawnPos, animalPrefabsRight[animalIndex].transform.rotation);
    }

}
