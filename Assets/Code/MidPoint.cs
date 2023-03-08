using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidPoint : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.tag == "Up" || other.gameObject.tag == "Down" || other.gameObject.tag == "Left" || other.gameObject.tag == "Right")
        {
            print("Triggered");
            Destroy(other.gameObject);
        }
    }
}
