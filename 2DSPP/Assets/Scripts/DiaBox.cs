using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class DiaBox : MonoBehaviour {
	public TextAsset textFile;
	public string[] textLine;
	public GameObject textBox;
	public Text theText;
	public int currLine;
	public int endAtLine;
	public PlayerController player;
	public int count=0;
	// Use this for initialization
	void Start () {

		player = FindObjectOfType<PlayerController> ();
		if (textFile != null) {
			textLine = (textFile.text.Split ('\n'));
		}if (endAtLine == 0) {
			endAtLine = textLine.Length - 1;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (count == 0)
			textBox.SetActive (false);
		else if (count==1)
			textBox.SetActive (true);
		if (Input.GetKeyDown (KeyCode.S)) {
			if (count == 0) {
				count++;
			}
		}
		else
		{

			theText.text = textLine [currLine];
		if(Input.GetKeyDown(KeyCode.A))
		   {
			currLine++;
		}
		if(currLine>endAtLine)
		{
			textBox.SetActive(false);
				count++;
		}
		}
		
	}


}
