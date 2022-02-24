using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject carToFollow;
    // the camera position should be the same as the yellow car
    void Start()
    {
        
    }

    void LateUpdate()
    {
        transform.position = carToFollow.transform.position + new Vector3(0, 0, -10);
    }
}
