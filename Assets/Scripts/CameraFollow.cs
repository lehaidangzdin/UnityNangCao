using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float folowSpeed = 3f;
    public float xOffset = 1f;

    // public float xOffset = 0.8f;

    public Transform target;


    // Update is called once per frame
    void Update()
    {

        Vector3 newPos =
               new Vector3(target.position.x +xOffset,1f, -10f);
        transform.position = Vector3.Slerp(transform.position, newPos, folowSpeed * Time.deltaTime);
        //

    }
}
