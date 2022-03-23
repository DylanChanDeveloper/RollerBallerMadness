using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    int hitCounter = 0;
    private void OnCollisionEnter(Collision collision)
    {
      // same is hitCounter = hitCounter + 1;
       
        
        if(collision.gameObject.tag != "Hit")
        {//means if the game object is not equal to hit then the hitcounter score will increase.
            hitCounter++;
            Debug.Log("you've bumped into a thing this many times: " + hitCounter);


        }
    }

}
