using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateController : MonoBehaviour
{
    [SerializeField] private GameObject _stone;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == _stone)
        {
            Level3Manager.instance.Stones += 1;
            Debug.Log(Level3Manager.instance.Stones);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == _stone)
        {
            Level3Manager.instance.Stones -= 1;
        }
    }
}
