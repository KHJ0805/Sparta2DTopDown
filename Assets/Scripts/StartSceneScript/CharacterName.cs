using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterName : MonoBehaviour
{
    // 플레이어 이름 선언
    public TextMesh PlayerName;

    // Start is called before the first frame update
    void Start()
    {
            PlayerName.text = GameManager.Instance.playerName;
    }
}
