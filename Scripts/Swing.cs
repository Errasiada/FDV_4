using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swing : MonoBehaviour
{
    public Star staryu;

    private void Start()
    {
        staryu.Onswing += Rotation;
        
    }

    private void Rotation()
    {
        Destroy(this.gameObject);
    }

    private void OnDestroy()
    {
        staryu.Onswing -= Rotation;
    }
}
