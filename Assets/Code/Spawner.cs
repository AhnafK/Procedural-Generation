using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] RightRooms;
    public GameObject[] LeftRooms;
    public GameObject[] TopRooms;
    public GameObject[] BottomRooms;
    public GameObject[] interiors;
    private int rand;
    public bool spawned = false;

    void Start(){
        Invoke("Spawn", 2);
    }

    public void Spawn(){
        
        if(spawned == false)
        {
            if (tag == "Up"){
                rand = Random.Range(0, TopRooms.Length);
                Instantiate(TopRooms[rand], transform.position, Quaternion.identity);
                print("Spawned Up");
            }
            if(tag == "Down"){
                rand = Random.Range(0, BottomRooms.Length);
                Instantiate(BottomRooms[rand], transform.position, Quaternion.identity);
                print("Spawned Down");
            }
            if(tag == "Left"){
                rand = Random.Range(0, LeftRooms.Length);
                Instantiate(LeftRooms[rand], transform.position, Quaternion.identity);
                print("Spawned Left");
            }
            if(tag == "Right"){
                rand = Random.Range(0, RightRooms.Length);
                Instantiate(RightRooms[rand], transform.position, Quaternion.identity);
                print("Spawned Right");
            }
            rand = Random.Range(0, interiors.Length);
            Instantiate(interiors[rand], transform.position, Quaternion.identity);
            print("Spawned Interior");
            spawned = true;
        }
    }

    // void OnTriggerEnter2D(Collision2D other){
    //     print("Triggered");
    //     Destroy(gameObject);
    // }

    // void OnCollisionEnter2D(Collision2D other){
    //     print("Triggered");
    //     Destroy(gameObject);
    // }
}
