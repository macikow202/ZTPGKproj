using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubesMovement : MonoBehaviour
{
    public Rigidbody cube;
    public float variable;
    public float counter = 0;
    float startingPosition;
    float endingPosition;
    float speed;
    float oppositeSpeed;
    Vector3 position;

    // Start is called before the first frame update
    void Start()
    {
        startingPosition = cube.position.z;
        counter = startingPosition;
        endingPosition = startingPosition + 50;
        position = cube.position;
        speed = variable;
        oppositeSpeed = variable * (-1);
    }

    // Update is called once per frame
    void Update()
    {
        cube.AddForce(0, 0, variable);

        if (cube.position.z > endingPosition)
        {
            position.z = endingPosition;
            cube.transform.position = position;
            variable = oppositeSpeed;
        }
        if (cube.position.z < startingPosition)
        {
            position.z = startingPosition;
            cube.transform.position = position;
            variable = speed;
        }
    }
}
