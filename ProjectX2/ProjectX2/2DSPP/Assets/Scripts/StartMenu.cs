using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class StartMenu : MonoBehaviour {
	public Canvas menu;
	public Button button;
	public void LoadScene(string name)
	{
		Application.LoadLevel (name);
	}
	// Use this for initialization
	void Start () {
		menu = menu.GetComponent<Canvas> ();
		button = button.GetComponent<Button> ();
	}
	
	// Update is called once per frame
	void Update () {

	
	}
}
