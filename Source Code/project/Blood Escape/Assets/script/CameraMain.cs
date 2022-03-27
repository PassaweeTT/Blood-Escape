using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMain : MonoBehaviour
{
    public Transform target;
    public float smoothing;
    public Vector3 offset;

    private void FixedUpdate()
    {
        //transform.position = target.position + offset;
    }
    // Update is called once per frame
    void LateUpdate()
    {
        if(transform.position != target.position)
        {
            Vector3 targetPosition = new Vector3(target.position.x,
                                                 target.position.y+1,target.position.z);
            transform.position = Vector3.Lerp(transform.position,
                                              targetPosition, smoothing) + offset;
        }
    }
}
