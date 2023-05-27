using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject pointPrefab;
    public GameObject spawnPoint;
    public float pointSpeed = 0.000003f;
    //Rigidbody2D pointRG;
    public int spawned = 0;
    float startTime = 0;
    float waitFor = 100;
    bool timerStart = true;



    void Start(){
        int spawn_number = Random.Range(0, 10);
        spawn_number = 1;
        //if (spawn_number == 1 && spawned <= 100)
            StartCoroutine(waiter());
  
    }

    IEnumerator waiter()
    {
                while (true){

            GameObject point = Instantiate(pointPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);
        //Wait for 4 seconds
        yield return new WaitForSeconds(4);
        }
    }


}
