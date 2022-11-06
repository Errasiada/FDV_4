using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Build.Content;
using UnityEngine;

public class Flower : MonoBehaviour
{
  private void OnTriggerEnter(Collider other)
  {
    Score.ScoreNum += 1;
    Destroy((gameObject));
  }
}
