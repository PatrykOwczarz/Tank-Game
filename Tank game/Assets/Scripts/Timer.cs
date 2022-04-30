using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public Text timerText;
	private float startTime;
    public Text finalTimeText;
	public static string finalTime;

    private string minutes;
    private string seconds;

    void Start () 
	{
		startTime = Time.time;
	}
	

	void Update () 
	{
		float t = Time.time - startTime;

	    minutes = ((int)t / 60).ToString ();
        seconds = (t % 60).ToString ("f2");

		timerText.text = "Time Survived: " + minutes + ":" + seconds;
        finalTime = minutes + ":" + seconds;
	}

    public void StoreEndTime()
    {
        finalTimeText.text = finalTime;
    }
}
