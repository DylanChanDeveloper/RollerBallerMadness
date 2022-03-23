using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
   //these variables are defined as information before we start.
  
   // [SerializeField]
   // float xValue = 0f; //we are creating/declaring a variable here. we are also "assigning" a value 0.01f to the variable

    [SerializeField] float yValue = 0f; //serializeField can be put beside your variable as well.

    //[SerializeField]
    //float zValue = 0f; //just not using public as a demostration

    [SerializeField]
    float moveSpeed;


    void Start()
    {//will run once at the start of a game
        printInstructions();
       
    }

   
    void Update()
    {//will always run per frame.
        playerMove();//for movement has to be in the update because we need to check everyframe if the players moving
    }

    public void playerMove()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        //this means when we push left or right on the keyboard we are returning a value of minus -1 for left and +1 for right.
        //we then multiply it by time.delta time to make the framerate independant
        //we then multiply by move speed to make it go faster
        //after all the multiplication the value is stored in xValue

        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        transform.Translate(xValue, yValue, zValue);
    }

    public void printInstructions()
    {
        print("WASD to move");
    }
}
