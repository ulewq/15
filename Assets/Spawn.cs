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



    void FixedUpdate(){

        float spawn_number = Random.Range(0, 2);
        if (spawn_number == 1 && spawned <= 10)
        {
            GameObject point = Instantiate(pointPrefab, spawnPoint.transform.position, spawnPoint.transform.rotation);
            //Rigidbody2D pointRG = point.GetComponent<Rigidbody2D>();
            //pointRG.AddForce(pointPoint.up * pointSpeed, ForceMode2D.Impulse);
            spawned+=1;
        }
    }
}
