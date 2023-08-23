using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(GameOverController))]
public class EnemyController : MonoBehaviour
{
    private GameOverController _gameOverController;

    private void Awake()
    {
        _gameOverController = GetComponent<GameOverController>();
    }

    /// <summary>
    /// Игрок входит в противника
    /// </summary>
    /// <param name="other"></param>
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _gameOverController.GameOver();
        }
    }
}
