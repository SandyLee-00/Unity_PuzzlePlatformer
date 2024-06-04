using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

/// <summary>
/// Player의 State에 따라 애니메이션을 변경하는 클래스
/// </summary>
public class PlayerAnimationController : MonoBehaviour
{
    Animator _animator;
    PlayerStateController _playerStateController;

    private void Awake()
    {
        _playerStateController = gameObject.GetOrAddComponent<PlayerStateController>();
        // _playerStateController.OnStateChangeEvent += ChangeAnimation;

    }

    private void Start()
    {
        _animator = GetComponentInChildren<Animator>();
        SoundManager.Instance.Play(Define.Sound.Bgm, "footstep05", 0.5f);

    }

    /*private void ChangeAnimation(PlayerState playerStateEnum)
    {
        switch (playerStateEnum)
        {
            case PlayerState.Idle:
                _animator.CrossFade("Idle_Battle", 0.1f);
                break;
            case PlayerState.Move:
                _animator.CrossFade("WalkForwardBattle", 0.1f);
                break;
            case PlayerState.Jump:
                _animator.CrossFade("RunForwardBattle", 0.1f);
                break;
            case PlayerState.Attack:
                _animator.CrossFade("Attack01", 0.1f);
                break;
            case PlayerState.Defend:
                _animator.CrossFade("Defend", 0.1f);
                break;
            case PlayerState.GetHit:
                _animator.CrossFade("GetHit", 0.1f);
                break;
            case PlayerState.Die:
                _animator.CrossFade("Die", 0.1f);
                break;
        }
    }*/

}