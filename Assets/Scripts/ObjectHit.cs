using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)//OnCollision enter is a callback.
    {
        // print("Bumped into a wall");
        if (collision.gameObject.tag == "Player") {
            GetComponent<MeshRenderer>().material.color = Color.green;
            //this code means we get the component called mesh renderer then we acess its properties with the dot operator to get the material then we access the color property in the material and re-assign it to color green.
            gameObject.tag = "Hit";
        }
    }
}
