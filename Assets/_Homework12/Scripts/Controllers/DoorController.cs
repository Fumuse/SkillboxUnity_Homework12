using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] private Animator _doorAnimator;
    [SerializeField] private TextMeshProUGUI _uiPressButton;
    private bool _inTrigger = false;

    private void Update()
    {
        if (_inTrigger)
        {
            if (Input.GetKeyDown(GlobalConstants.ACTION_BUTTON))
            {
                _doorAnimator.SetBool("DoorIsOpen", !_doorAnimator.GetBool("DoorIsOpen"));
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _inTrigger = true;
            ChangeUiActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            _inTrigger = false;
            ChangeUiActive(false);
        }
    }

    private void ChangeUiActive(bool active)
    {
        if (_doorAnimator.GetBool("DoorIsOpen"))
        {
            _uiPressButton.gameObject.SetActive(false); 
        }
        else
        {
            _uiPressButton.gameObject.SetActive(active); 
        }
    }
}
