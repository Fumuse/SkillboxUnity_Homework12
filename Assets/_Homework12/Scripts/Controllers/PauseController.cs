using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    public void SetPause(bool pause)
    {
        if (pause) Time.timeScale = 0f;
        else Time.timeScale = 1f;
    }
}
