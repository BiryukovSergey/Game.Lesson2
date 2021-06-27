using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class FlyPanel : MonoBehaviour
{
    public Transform pos;
    public float numeric;
   
    private void Start()
    {
        numeric = Random.Range(2.0f, 3.5f);
    }

    private void LateUpdate()
    {
        pos.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time, numeric),
            transform.position.z);
    }
}
