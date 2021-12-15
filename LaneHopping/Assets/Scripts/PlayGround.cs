using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGround : MonoBehaviour
{
    public Spawner[] spawners;

    private int randomNumberGenerator(){
        return Random.Range(0, 4);
    }

    private void Start() {
        
    }


    IEnumerator RandomSpawn(){
        while(true){
            spawners[randomNumberGenerator()].setActiveTrue();
        }
    }

}
