using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawner;
    public GameObject[] prefabs;

    private bool active;
    
    private void Start() {
        active = false;
        StartCoroutine(wait());
    }
    
    public void setActiveTrue(){
        active = true;
    }

    public void setActiveFalse(){
        active = false;
    }
    
    private int randomNumberGenerator(int arraySize){
        return Random.Range(0, arraySize);
    }

    private void spawnObstacles(){
        GameObject.Instantiate(prefabs[Random.Range(0, prefabs.Length)], spawner.transform.position, Quaternion.identity);
    }

    IEnumerator wait(){
        while(true){
            spawnObstacles();
            yield return new WaitForSeconds(Random.Range(2, 7));
        }

    }
}
