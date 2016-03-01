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
	// Use this for initialization
	void Start () {
		player = FindObjectOfType<PlayerController> ();
		if (textFile != null) {
			textLine = (textFile.text.Split ('\n'));
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
