using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent; // action은 무조건 void만 반환해야함. 아니면 func
    public event Action<Vector2> OnLookEvent;
    public event Action OnAttackEvent;

    protected bool isAttacking { get; set; }

    private float timeSinceLastAttack = float.MaxValue;

    private void Update()
    {
        HandleAttackDelay();
    }


    private void HandleAttackDelay()
    {
        //todo magic number fix
        if(timeSinceLastAttack < 0.2f)
        {
            timeSinceLastAttack += Time.deltaTime;
        }
        else if(isAttacking  && timeSinceLastAttack >= 0.2f)
        {
            timeSinceLastAttack = 0f;
            CallAtackEvent();
        }
    }

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction); // ? -> 없으면 말고 있으면 실행
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

    private void CallAtackEvent()
    {
        OnAttackEvent?.Invoke();
    }
}
