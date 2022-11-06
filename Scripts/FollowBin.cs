using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowBin : MonoBehaviour
{
    public GameObject bin;
    public float speed;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(
            transform.position, 
            new Vector3(bin.transform.position.x,transform.position.y,bin.transform.position.z), 
            speed * Time.deltaTime);
    }
}
