using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderChanger : MonoBehaviour
{
    public Slider changer;
    // Start is called before the first frame update
    void Start()
    {
        changer = GetComponent<Slider>();
    }

    public void ChangeValue(float increment)
    {
        changer.value += 0.1f;
    }
}
