
using UnityEngine;
using Random = UnityEngine.Random;
public class spawner : MonoBehaviour
{
  public GameObject fish;
 
  public bool stopSpawning = false;
  public float spawnTime;
  public float spawnDelay;
  void Start(){
    InvokeRepeating("SpawnFish", spawnTime, spawnDelay);
  }
  public void SpawnFish(){
    int spawnPointX = Random.Range (-10,10);
    int spawnPointY = Random.Range (1,2);
    int spawnPointZ = Random.Range (-10,10);

    Vector3 spawnPosition = new Vector3(spawnPointX, spawnPointY, spawnPointZ);

    Instantiate (fish, spawnPosition, Quaternion.identity);

   
    
    if (stopSpawning){
        CancelInvoke("SpawnFish");
    }
  }
}
