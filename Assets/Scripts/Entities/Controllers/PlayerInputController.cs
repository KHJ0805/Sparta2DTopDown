using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : TopDownController
{
    private Camera camera;

    protected override void Awake()
    {
        base.Awake();
        camera = Camera.main; //maincamera 라는 태그가 붙어있는 카메라를 가져온다.
    }

    public void OnMove(InputValue value)
    {
        Vector2 moveinput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveinput);
    }

    public void OnLook(InputValue value)
    {
        Vector2 newaim = value.Get<Vector2>();
        Vector2 wolrdPos = camera.ScreenToWorldPoint(newaim);
        newaim = (wolrdPos - (Vector2)transform.position).normalized;

        CallLookEvent(newaim);
    }

    public void OnFire(InputValue value)
    {
        isAttacking = value.isPressed;
    }
}
