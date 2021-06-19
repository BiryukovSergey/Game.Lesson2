using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] protected Transform[] _transformsSpawnsSphere;
    [SerializeField] internal GameObject _gameObject;

    private void Awake()
    {
        for (int i = 0; i < _transformsSpawnsSphere.Length; ++i)
        {
            Instantiate(_gameObject, transform.position, transform.rotation);
            transform.position = _transformsSpawnsSphere[i].transform.position;
        }
    }
}
