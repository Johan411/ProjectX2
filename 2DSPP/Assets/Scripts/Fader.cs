using UnityEngine;
using System.Collections;

public class Fader : MonoBehaviour {
	
	public float fadeSpeed  = 1.5f;            // Speed that the screen fades to and from black.
	
	
    private bool sceneStarting = true;     // Whether or not the scene is still fading in.
	
	
	 void Awake ()
	{
		// Set the texture so that it is the the size of the screen and covers it.
		GetComponent<GUITexture>().pixelInset = new Rect(0f, 0f, 100, 100);
	/*	public GUITexture abc=GetComponent.<G;
		abc.pixelInset=new Rect(0f, 0f, 100, 1)*/
	}
	

	 void Update ()
	{
		// If the scene is starting...
		if(sceneStarting)
			// ... call the StartScene function.
			StartScene();
	}
	
	
	public void FadeToClear ()
	{
		// Lerp the colour of the texture between itself and transparent.
		GetComponent<GUITexture>().color = Color.Lerp(GetComponent<GUITexture>().color, Color.clear, fadeSpeed * Time.deltaTime);
	}
	
	
	public void FadeToBlack ()
	{
		// Lerp the colour of the texture between itself and black.
		GetComponent<GUITexture>().color = Color.Lerp(GetComponent<GUITexture>().color, Color.black, fadeSpeed*40 * Time.deltaTime);
	}
	
	
	public void StartScene ()
	{
		// Fade the texture to clear.
		FadeToClear();
		
		// If the texture is almost clear...
		if(GetComponent<GUITexture>().color.a <= 0.05f)
		{
			// ... set the colour to clear and disable the GUITexture.
			GetComponent<GUITexture>().color = Color.clear;
			GetComponent<GUITexture>().enabled = false;
			
			// The scene is no longer starting.
			sceneStarting = false;
		}
	}
	
	
	public void EndScene ()
	{
		// Make sure the texture is enabled.
		GetComponent<GUITexture>().enabled = true;
		
		// Start fading towards black.
		FadeToBlack();
		Debug.Log(GetComponent<GUITexture> ().color);
		// If the screen is almost black...
		if(GetComponent<GUITexture>().color.a >= 0.95f)
								Application.LoadLevel(2);

	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	//void Update () {
	
	//}
}
