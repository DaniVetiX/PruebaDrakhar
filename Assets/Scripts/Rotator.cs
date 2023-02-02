using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    //Editor Variables
    public bool isRotating;
    public float Speed;
    
    //Local Variables
    private float sum;

    private void Update()
    {
        if (isRotating)
        {
            sum++;
            this.transform.rotation = Quaternion.AngleAxis(30 * (sum * Speed), Vector3.up);
        }
    }
}
