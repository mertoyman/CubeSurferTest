using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] float height;
    [SerializeField] float distance;
    //[SerializeField] float offsetX;
    
    private Vector3 pos;
    
    void Start()
    {
        pos = this.transform.position;
    }

    void LateUpdate()
    {
        //pos.x = target.transform.position.x + offsetX;
        pos.y = Mathf.Lerp(pos.y, target.transform.position.y + height, Time.deltaTime);
        pos.z = target.transform.position.z - distance;
        transform.position = pos;
    }
}
