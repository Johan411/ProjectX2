using UnityEngine;
using System.Collections;

public class conversation : MonoBehaviour {
	public TextAsset textFile;
	public string[] textLine;
	// Use this for initialization
	void Start () {
	if (textFile != null) {
			textLine = (textFile.text.Split ('\n'));
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
