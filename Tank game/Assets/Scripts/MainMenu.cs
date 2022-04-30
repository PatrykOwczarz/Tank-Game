using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    private string skyboxValue;

    void Start ()
    {
        skyboxValue = PlayerPrefs.GetString("Skybox");
		if (skyboxValue == "") {
			RenderSettings.skybox = (Material)Resources.Load ("Skybox4");
		}
		else 
		{
			RenderSettings.skybox = (Material)Resources.Load(skyboxValue);	
		}
    }

    public void PlayButton()
    {
        SceneManager.LoadScene("Game");
    }

    public void ExitGameButton()
    {
        Application.Quit();
    }

    public void Skybox1Button()
    {
        RenderSettings.skybox = (Material)Resources.Load("Skybox1");
        PlayerPrefs.SetString("Skybox", "Skybox1");
    }

    public void Skybox2Button()
    {
        RenderSettings.skybox = (Material)Resources.Load("Skybox2");
        PlayerPrefs.SetString("Skybox", "Skybox2");
    }

    public void Skybox3Button()
    {
        RenderSettings.skybox = (Material)Resources.Load("Skybox3");
        PlayerPrefs.SetString("Skybox", "Skybox3");
    }

    public void Skybox4Button()
    {
        RenderSettings.skybox = (Material)Resources.Load("Skybox4");
        PlayerPrefs.SetString("Skybox", "Skybox4");
    }

    public void Skybox5Button()
    {
        RenderSettings.skybox = (Material)Resources.Load("Skybox5");
        PlayerPrefs.SetString("Skybox", "Skybox5");
    }

    public void Skybox6Button()
    {
        RenderSettings.skybox = (Material)Resources.Load("Skybox6");
        PlayerPrefs.SetString("Skybox", "Skybox6");
    }

}
