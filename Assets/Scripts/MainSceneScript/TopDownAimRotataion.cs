using System;
using UnityEngine;

public class TopDownAimRotataion : MonoBehaviour
{
    [SerializeField] private SpriteRenderer aimRenderer;
    [SerializeField] private Transform armPivot;

    [SerializeField] private SpriteRenderer characterRenderer;

    private TopDownController controller;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
    }
    private void Start()
    {
        controller.OnLookEvent += Onaim;
    }

    private void Onaim(Vector2 direction)
    {
        RotateArm(direction);
    }

    private void RotateArm(Vector2 direction)
    {

        // 캐릭터에서 마우스 포인터까지의 x,y 값으로 각도를 구함(mathf.atan2) , 그리고 이 값은 라디안값이기 때문에 이 값을 각도로 변환)
        float rotZ = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        // 그러므로 rotZ는 현재 마우스 포인터 있는 방향의 각도 정보값이니 그쪽으로 각도를 지정해줘라
        armPivot.rotation = Quaternion.Euler(0, 0, rotZ);

        // abs = absoulte value = 절대값
        characterRenderer.flipX = Mathf.Abs(rotZ) > 90f;
    }
}