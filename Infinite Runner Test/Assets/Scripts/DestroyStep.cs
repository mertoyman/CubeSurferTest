using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyStep : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Step"))
        {
            if (GetComponent<Renderer>().material.color == other.GetComponent<Renderer>().material.color)
            {
                Destroy(this.gameObject);
            }
        }
    }
}
