using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawn : MonoBehaviour
{
    [SerializeField] protected Transform[] _transformsSpawnsBadSphere;
    [SerializeField] protected Transform[] _transformsSpawnsGoodSphere;
    [SerializeField] internal GameObject _gameObjectBadDonus;
    [SerializeField] internal GameObject _gameObjectGoodDonus;
    
    private void Awake()
    {
        for (int i = 0; i < _transformsSpawnsBadSphere.Length; ++i)
        {
            Instantiate(_gameObjectBadDonus, transform.position, transform.rotation);
            transform.position = _transformsSpawnsBadSphere[i].transform.position;
        }
        
        for (int i = 0; i < _transformsSpawnsGoodSphere.Length; ++i)
        {
            Instantiate(_gameObjectGoodDonus, transform.position, transform.rotation);
            transform.position = _transformsSpawnsGoodSphere[i].transform.position;
        }
    }
}
