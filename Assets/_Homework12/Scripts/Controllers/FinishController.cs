using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishController : MonoBehaviour
{
    private int _activeScene = 0;
    private int _nextScene = 0;

    private void Awake()
    {
        _activeScene = SceneManager.GetActiveScene().buildIndex;
        _nextScene = _activeScene + 1;
    }

    /// <summary>
    /// Обработка попадания в финиш
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (_nextScene < SceneManager.sceneCountInBuildSettings)
            {
                SceneManager.LoadScene(_nextScene);
            }
        }
    }
}
