using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class StartSceneMenu : MonoBehaviour
{
    public GameObject checkCharac;
    public TextMeshProUGUI warningText;

    void Start()
    {
        warningText.gameObject.SetActive(false);
    }

    public void ChooseCharacter(GameObject character)
    {
        GameManager.Instance.SelectedCharacter = character;
        checkCharac = character;
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void PlayGame()
    {
        if (checkCharac == null)
        {
            warningText.text = "Please select a Character";
            warningText.gameObject.SetActive(true);
            return;
        }
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
