using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float score = 0;

    public float addScore = 1;

    public float timer;

    public bool crashed;
    private void Awake() {
        crashed = false;
    }
    public void calculateScore(){
        timer += Time.deltaTime;
        if(!crashed){
            if (timer > 1f){
                score += addScore;
                timer = 0;
            }
        }
    }


    private void Update() {
        calculateScore();
        Debug.Log(score);
    }
}
