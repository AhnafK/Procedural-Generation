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
    public int max = 12;

    void Start(){
        Invoke("Spawn", 0.15f);
    }

    public void Spawn(){
        
        if(spawned == false)
        {
            bool cap = capCheck();
            if (tag == "Up"){
                rand = Random.Range(0, TopRooms.Length);
                if(cap == true){
                    rand = 0;
                }
                Instantiate(TopRooms[rand], transform.position, Quaternion.identity);
                //print("Spawned Up");
            }
            if(tag == "Down"){
                rand = Random.Range(0, BottomRooms.Length);
                if(cap == true){
                    rand = 0;
                }
                Instantiate(BottomRooms[rand], transform.position, Quaternion.identity);
                print("Spawned Down");
            }
            if(tag == "Left"){
                rand = Random.Range(0, LeftRooms.Length);
                if(cap == true){
                    rand = 0;
                }
                Instantiate(LeftRooms[rand], transform.position, Quaternion.identity);
                //print("Spawned Left");
            }
            if(tag == "Right"){
                rand = Random.Range(0, RightRooms.Length);
                if(cap == true){
                    rand = 0;
                }
                Instantiate(RightRooms[rand], transform.position, Quaternion.identity);
                //print("Spawned Right");
            }
            rand = Random.Range(0, interiors.Length);
            Instantiate(interiors[rand], transform.position, Quaternion.identity);
            //print("Spawned Interior");
            spawned = true;
        }
    }

    bool capCheck(){
        int cap = 0;
        cap += GameObject.FindGameObjectsWithTag("Up").Length;
        cap += GameObject.FindGameObjectsWithTag("Down").Length;
        cap += GameObject.FindGameObjectsWithTag("Left").Length;
        cap += GameObject.FindGameObjectsWithTag("Right").Length;
        print(cap);
        if (cap > max){
            print("Cap Reached");
            return true;
        }
        return false;
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
