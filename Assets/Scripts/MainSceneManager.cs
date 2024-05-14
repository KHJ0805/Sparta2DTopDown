using System.Collections;
using System.Collections.Generic;
using Unity.Burst.CompilerServices;
using UnityEngine;

public class MainSceneManager : MonoBehaviour
{
    public GameObject Knight;
    public GameObject Penguin;

    private void Start()
    {
        int characterIdx = GameManager.Instance.CharacterIdx;

        if (characterIdx == 1)
        {
            Knight.SetActive(true);
        }
        else
        {
            Penguin.SetActive(true);
        }
    }
 
}
