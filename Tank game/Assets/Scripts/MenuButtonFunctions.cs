using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuButtonFunctions : MonoBehaviour {

    public GameObject PauseMenu;
    private bool isPauseMenuOn;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPauseMenuOn == false)
            {
                Time.timeScale = 0f;
                PauseMenu.SetActive(true);
                isPauseMenuOn = true;
            }
            else
            {
                Time.timeScale = 1f;
                PauseMenu.SetActive(false);
                isPauseMenuOn = false;
            }
        }
    }

    public void ReturnToMainMenuButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }

    public void ResumeButton()
    {
        Time.timeScale = 1f;
        PauseMenu.SetActive(false);
    }

}
