using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    
    [SerializeField] GameObject[] kidsToSpawn;
    public GameObject currentKid;
    public GameObject currentlocation;
    public GameObject[] positionSpawn;
    public bool isRandomized;
    int index;
    int indexSpawnLocations;
    public void Start() {
        positionSpawn = GameObject.FindGameObjectsWithTag("SpawnLocation");
    }
    // Start is called before the first frame update
    public void spawn()
    {
        kidsToSpawn = GameObject.FindGameObjectsWithTag("Customer");
        index = Random.Range (0, kidsToSpawn.Length);
        indexSpawnLocations= Random.Range(0, positionSpawn.Length);
        currentKid = kidsToSpawn[index];
        Debug.Log(currentKid);
        Debug.Log(indexSpawnLocations);
        currentlocation = positionSpawn[indexSpawnLocations];
        Debug.Log(currentlocation);
        Debug.Log(currentKid);
        Debug.Log("HEY");
        Instantiate(currentKid, currentlocation.transform.position, currentlocation.transform.rotation);
        
    }

}
