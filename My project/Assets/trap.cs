using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class trap : MonoBehaviour
{
    public Slider healthBar;
    public float damageAmount = 0.01f;

   void OnTriggerEnter(Collider other)
   {
    healthBar.value -= damageAmount;
   }
}
