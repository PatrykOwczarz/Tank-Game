using UnityEngine;

public class SkyboxController : MonoBehaviour {

    private string skyboxValue;

	void Start () {

		skyboxValue = PlayerPrefs.GetString("Skybox");
		if (skyboxValue == "") {
			RenderSettings.skybox = (Material)Resources.Load ("Skybox4");
		}
		else 
		{
			RenderSettings.skybox = (Material)Resources.Load(skyboxValue);	
		}

		//RenderSettings.skybox = (Material)Resources.Load("Skybox2");
		//RenderSettings.skybox = (Material)Resources.Load("Skybox3");
		//RenderSettings.skybox = (Material)Resources.Load("Skybox4");
		//RenderSettings.skybox = (Material)Resources.Load("Skybox5");
		//RenderSettings.skybox = (Material)Resources.Load("Skybox6");
	}
}
