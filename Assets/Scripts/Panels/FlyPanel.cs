using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class FlyPanel : MonoBehaviour
{
    public Transform pos;
    public float numeric;
    public float numeric1;
    private void Start()
    {
        numeric = Random.Range(0.5f, 2.7f);
        numeric1 = Random.Range(0.5f, 2.7f);
    }

    private void LateUpdate()
    {
        pos.localPosition = new Vector3(transform.localPosition.x, Mathf.PingPong(Time.time, numeric),
            transform.localPosition.z);
    }
}
