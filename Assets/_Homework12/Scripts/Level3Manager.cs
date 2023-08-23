using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3Manager : MonoBehaviour
{
    [SerializeField] private GameObject _bridge;
    [SerializeField] private int _stonesCount = 4;

    public static Level3Manager instance = null; // Экземпляр объекта
    private int _stones = 0;

    public int Stones
    {
        get { return _stones;}
        set
        {
            _stones = value;
            ChangeBridgeActive();
        }
    }

    private void ChangeBridgeActive()
    {
        if (_stones == _stonesCount) _bridge.SetActive(true);
        else _bridge.SetActive(false);
    }

    private void Awake()
    {
        if (instance == null) instance = this;
    }
}
