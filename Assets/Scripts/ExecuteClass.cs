using System;
using System.Collections.Generic;
using UnityEngine;

public class ExecuteClass : MonoBehaviour
{
    private List<IExecute> _executes;
    
    private void Awake()
    {
        _executes = new List<IExecute>();
    }
    
    private void Update()
    {
        foreach (var O in _executes)
        {
            O.Update();
        }
    }

    public void AddInterface(IExecute execute)
    {
        _executes.Add(execute);
    }
}
