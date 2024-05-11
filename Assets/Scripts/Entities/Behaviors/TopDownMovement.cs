using System;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    // 실제로 이동이 일어날 컴포넌트
    private TopDownController controller;
    private Rigidbody2D movementrigidbody;

    private CharacterStatHandler characterStatHandler;

    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        // controller 랑 topdownmovement 랑 같은 게임오브젝트에 있다는 가정
        controller = GetComponent<TopDownController>();
        movementrigidbody = GetComponent<Rigidbody2D>();
        characterStatHandler = GetComponent<CharacterStatHandler>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;

    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void FixedUpdate()
    {
        //FixedUpdate 는 물리 업데이트 관련
        // rigidbody 값을 바꾸니 사용함
        ApplyMovement(movementDirection);
    }

    private void ApplyMovement(Vector2 direction)
    {
        direction *= characterStatHandler.CurrentStat.speed;
        movementrigidbody.velocity = direction;
    }
}