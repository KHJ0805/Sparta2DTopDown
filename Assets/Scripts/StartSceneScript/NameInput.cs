using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NameInput : MonoBehaviour
{

    public InputField playerNameInputField;
    public GameObject PlayerNameInput;
    public GameObject CharSelect;
    public string playerName;



    public void InputName()
    {
        playerName = playerNameInputField.text;
        if (playerName.Length > 1)
        {
            playerName = playerNameInputField.GetComponent<InputField>().text;
            GameManager.Instance.playerName = playerName;
            PlayerNameInput.SetActive(false);
            CharSelect.SetActive(true);
        }
    }
}
