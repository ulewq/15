using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision){
        Debug.Log(collision);
        Destroy(this.gameObject);
     }
}
