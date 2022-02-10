using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void OnCollisionEnter(Collision other) 
    {
        Debug.Log("Ouch!!");
    }
}
