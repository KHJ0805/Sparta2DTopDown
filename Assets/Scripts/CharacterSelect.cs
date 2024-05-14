using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour
{
    int characterIdx = 0;
    public GameObject ChaLine1;
    public GameObject ChaLine2;

    public void Pick1()
    {
        characterIdx = 1;
        ChaLine1.SetActive(true);
        ChaLine2.SetActive(false);
    }

    public void Pick2()
    {
        characterIdx = 2;
        ChaLine1.SetActive(false);
        ChaLine2.SetActive(true);
    }

    public void PickButton()
    {
        if(characterIdx > 0)
        {
            SceneManager.LoadScene("MainScene");
            GameManager.Instance.CharacterIdx = characterIdx;
        }
        else
        {
            return;
        }

    }
}
