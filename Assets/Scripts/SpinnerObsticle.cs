using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerObsticle : MonoBehaviour
{
    [SerializeField]
    float xValue,yValue,zValue;//creating variables for x,y,z to pass into rotation through the console.
                                //value will default to 0 since we didn't specify a number.
   

    void Start()
    {
        ObjectRoation();
    }

    // Update is called once per frame
    void Update()
    {
        ObjectRoation();
    }

    void ObjectRoation()
    {
        transform.Rotate(xValue, yValue, zValue);
    }
}
