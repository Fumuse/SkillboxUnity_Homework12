using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int Memories { get; set; } = 0;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
