using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField]
    float timeCompariosn = 3f;

    MeshRenderer renderer;
    Rigidbody rb;

   
    void Start()
    {
        //getComponentStores();
        renderer = GetComponent<MeshRenderer>();//when defining the variable we can store the e.g.  renderer = GetComponent<MeshRenderer>(); in a method and call that method in start e.g. below
        rb = GetComponent<Rigidbody>();//we are caching the component here also

        renderer.enabled = false;//we then use the variable name to access the component properties.
          rb.useGravity = false;

        //GetComponent<Rigidbody>().useGravity = false; none cache way of writing thr same code.
    }

    // Update is called once per frame
    void Update()
    {
        timeChecker();
        //we put it in update so we can check everyframe
    }  

    public void timeChecker()
    {
        if (Time.time > timeCompariosn)
        {       
            renderer.enabled = true;
             rb.useGravity = true;

            //  GetComponent<Rigidbody>().useGravity = true;
        }

      //  Debug.Log(Time.time);//Time is the class, .time is its property, blue color in unity means its a class.
    }

    //public void getComponentStores()
    //{
    //    renderer = GetComponent<MeshRenderer>();
    //    rb = GetComponent<Rigidbody>();
    //}
}
