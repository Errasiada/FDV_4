using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public float speed;
    
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, 
            new Vector3(player.transform.position.x,transform.position.y,player.transform.position.z), 
            speed * Time.deltaTime);
    }
}
