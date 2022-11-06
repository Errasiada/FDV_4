using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Star : MonoBehaviour
{

    public delegate void swing();

    public event swing Onswing;

    private void OnTriggerEnter(Collider other)
    {
        Onswing();
        Destroy(this.gameObject);
    }
}
