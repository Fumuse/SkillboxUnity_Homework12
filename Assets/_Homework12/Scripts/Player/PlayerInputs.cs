using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(PlayerController))]
[RequireComponent(typeof(Rigidbody))]
public class PlayerInputs : MonoBehaviour
{
    private PlayerController _playerController;
    private Rigidbody _playerRB;

    private Vector3 _movement;

    public Vector3 Movement
    {
        get { return _movement; }
    }

    private void Awake()
    {
        _playerRB = GetComponent<Rigidbody>();
        _playerController = GetComponent<PlayerController>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis(GlobalConstants.HORIZONTAL_AXIS);
        float vertical = Input.GetAxis(GlobalConstants.VERTICAL_AXIS);
        _movement = new Vector3(horizontal, _playerRB.velocity.y, vertical).normalized;
        
        if (Input.GetButtonDown(GlobalConstants.JUMP))
        {
            _playerController.Jump();
        }
    }
}