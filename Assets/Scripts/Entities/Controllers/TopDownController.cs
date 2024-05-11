using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour
{
    public event Action<Vector2> OnMoveEvent; // action은 무조건 void만 반환해야함. 아니면 func
    public event Action<Vector2> OnLookEvent;
    public event Action<AttackS0> OnAttackEvent;

    protected bool isAttacking { get; set; }

    private float timeSinceLastAttack = float.MaxValue;

    protected CharacterStatHandler stats { get; private set; }

    protected virtual void Awake()
    {
        stats = GetComponent<CharacterStatHandler>();
    }

    private void Update()
    {
        HandleAttackDelay();
    }


    private void HandleAttackDelay()
    {
        if (timeSinceLastAttack < stats.CurrentStat.attackS0.delay)
        {
            timeSinceLastAttack += Time.deltaTime;
        }
        else if(isAttacking  && timeSinceLastAttack >= stats.CurrentStat.attackS0.delay)
        {
            timeSinceLastAttack = 0.1f;
            CallAtackEvent(stats.CurrentStat.attackS0);
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

    private void CallAtackEvent(AttackS0 attackS0)
    {
        OnAttackEvent?.Invoke(attackS0);
    }
}
