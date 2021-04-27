using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PendulumMovement : MonoBehaviour
{
    float step = 0.1f;
    int counter = 500;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (counter==1000)
        {
            step = step * (-1);
            counter = 0;
        }

        gameObject.transform.Rotate(step, 0, 0);
        counter++;

    }
}
