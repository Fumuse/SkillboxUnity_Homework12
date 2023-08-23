using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class EaterAnimationController : MonoBehaviour
{
    [SerializeField] private float _animationPause = 2.5f;
    private Animator _animator;
    private float _defaultSpeed;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
        _defaultSpeed = _animator.speed;
    }

    public void AnimationEnd()
    {
        StartCoroutine(AnimationCoroutine());
    }

    private IEnumerator AnimationCoroutine()
    {
        _animator.speed = 0;
        yield return new WaitForSeconds(_animationPause);
        _animator.speed = _defaultSpeed;
    }
}
