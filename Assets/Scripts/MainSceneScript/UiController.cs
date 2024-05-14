using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiController : MonoBehaviour
{
    public void CharacterChangeBtn()
    {
        // 시간 멈추고
        // 캐릭터창 띄우고
        // 캐릭터 고르고
        // 확인 누르면 내 플레이어 캐릭터가 바뀌어야 함
        Time.timeScale = 0;
    }

    public void PlayerNameChangeBtn()
    {
        //시간 멈추고
        // 인풋필드 띄우고
        // 안에 글자수 조절
        // 확인 누르면 캐릭터 이름 바뀌어야 함
        Time.timeScale = 0;
    }

    public void CheckAttending()
    {
        //맵에 있는 GameObject 리스트
        // tag... 사용하면 될까?
    }
}
