using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alarm : MonoBehaviour
{
    [SerializeField] private float _maxVolume;
    private float _minVolume = 0;

    private bool _isPenetration = false;

    private void OnTriggerEnter(Collider other)
    {
        
    }

    private void FixedUpdate()
    {
        if (_isPenetration)
        {
             
        }
        else
        {

        }
        
    }

    
}
