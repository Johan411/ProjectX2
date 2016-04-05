using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CutSceneScript : MonoBehaviour {

	public TextAsset textFile;
	public GameObject textBox;
	public GameObject RightSprite;
	public GameObject LeftSprite;
	public string[] textLines;
	public int currLine;
	public int lastLine;
	public Text inText;
	private bool Enabled;
	private string heading;
	private Camera main;
	private Vector3 offset;
	private int i;
	private float letterPause = 0.05f;
	private char letter;
	// Use this for initialization
	void Start () {
		Enabled = true;
		i = Application.loadedLevel;
		main = Camera.main;
		offset = new Vector3(1366,0,0);
		textLines = (textFile.text.Split('\n'));
		inText.text = "";
		lastLine = textLines.Length;
		LeftSprite.SetActive (false);
		RightSprite.SetActive (false);
		if (i != 6) {
			StartCoroutine (Typetext ());
		}
		}
	
	// Update is called once per frame
	void Update () {
		 //inText.te	xt = textLines [currLine];
		if (Input.GetKeyDown (KeyCode.E) && (Enabled )) {
			if(textLines[currLine][0] == 'L' && textLines[currLine][1] == 'e' && textLines[currLine][2] == 'f')
			   {
				LeftSprite.SetActive(true);
				RightSprite.SetActive(false);
				inText.text = "";
				currLine += 1;
			}
			else if(textLines[currLine][0] == 'R' && textLines[currLine][1] == 'i' && textLines[currLine][2] == 'g')
			{
				LeftSprite.SetActive (false);
				RightSprite.SetActive (true);
				inText.text = "";
				currLine += 1;
			}
			else
			{
				StartCoroutine (Typetext ());
				currLine += 1;
			}
			if(i==1)
			{
				main.transform.position = main.transform.position + offset;
				textBox.transform.position = textBox.transform.position + offset;
			}
		}
		else if(Input.GetKeyDown (KeyCode.Return))
		        {
			Application.LoadLevel(i+1);
		}
	}

	 IEnumerator Typetext ()
		{
		Enabled = false;
		inText.text = "";
		foreach (char letter in textLines[currLine].ToCharArray()) {
			inText.text += letter;
			yield return new WaitForSeconds (letterPause);
		}
		if(currLine>=lastLine)
		{
			Application.LoadLevel (i+1);
		}
		Enabled = true;
	}
}
