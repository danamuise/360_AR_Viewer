using UnityEngine;
using System.Collections;

public class ShowImage : MonoBehaviour {

	public GameObject overlay;
	private bool show;
	// Use this for initialization
	void Start () {
		show = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void toggleImage(){
		if (show) {
			overlay.SetActive (false);
			show = false;
		} else {
			overlay.SetActive (true);
			show = true;
		}
	}
}
