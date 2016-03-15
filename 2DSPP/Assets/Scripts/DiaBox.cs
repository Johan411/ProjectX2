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
	public GameObject Player1;
	public GameObject Player2;
	public char[] Character;
	public int i;
	public string charboy;
	public int count2=0;
	// Use this for initialization
	void Start () {
		count2 = 0;
	
		Character = new char[10];
		Player1= GameObject.FindGameObjectWithTag ("boy");
		Player1.SetActive(false);
		Player2= GameObject.FindGameObjectWithTag ("sage");
		Player2.SetActive(false);
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
		if (Input.GetKeyDown (KeyCode.E) && count == 0) {
			if (count == 0) {
				count++;
			}
		} 
		else {
			theText.text = textLine [currLine];
			for (i=0; theText.text[i]=='\0'; i++) {
				Character [i] = theText.text [i];
				Debug.Log(Character[i]);
			}

		//	charboy = new string (Character);

			if (theText.text[0]=='N'&&theText.text[1]=='i'&&theText.text[2]=='m')
			{		Player1.SetActive(true);
				Player2.SetActive(false);
					currLine++;}
			if (theText.text[0]=='S'&&theText.text[1]=='a'&&theText.text[2]=='g')
			{		Player2.SetActive(true);
				Player1.SetActive(false);
				currLine++;}

		
				//else 
			Debug.Log("Reached");
				if (Input.GetKeyDown (KeyCode.E)) {
					currLine++;

				}
			if(Input.GetKeyDown(KeyCode.Return))
			   {textBox.SetActive (false);
				Player1.SetActive(false);
				Player2.SetActive(false);
				count++;}
			if (currLine > endAtLine) {
					textBox.SetActive (false);
				Player1.SetActive(false);
				Player2.SetActive(false);
					count++;
				}

	}
}




}
