using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DropDown_menu : MonoBehaviour {

	public Dropdown dropDown;
	private bool usingGPS;
	//drop down items
	List<string> selections = new List<string> (){"Use preset locations", "Chinatown, SF", "Beijing, China" };
	public Text warning;
	private int _index;
	public Toggle toggleGPS;
	public Toggle togglePreset;

	// Use this for initialization
	void Start () {
		PopulateList ();
		usingGPS = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Dropdown_IndexChanged(int index){
		_index = index;

		if (_index == 1) {
			Debug.Log ("Chinatown: "+ _index);
		}
		if (_index == 2) {
			Debug.Log ("Beijing: "+ _index);
		}
	}

	void PopulateList(){
		
		dropDown.AddOptions (selections);
	}

	public void launchScene(){
		if (togglePreset.isOn) {
			if (_index == 0) {
				warning.text = "Please select a location above";
				Debug.Log ("Error: Make a selection "+ _index);
			}
			if (_index == 1) {
				Debug.Log ("Load Chinatown: " + _index);
				SceneManager.LoadScene ("Map_Chinatown", LoadSceneMode.Single);
			}
			if (_index == 2) {
				Debug.Log ("Load Beijing: " + _index);	
				SceneManager.LoadScene ("Map_Beijing", LoadSceneMode.Single);
			}
		} else if (toggleGPS.isOn) {
			Debug.Log ("Load GPS: " + _index);
			SceneManager.LoadScene ("Map_GPS", LoadSceneMode.Single);
		}
	}

	//toogle sitches for choosing device gps or preset locations
	/*
	public void toogleGPS(bool set){
		if (usingGPS && !set) {
			usingGPS = false;
			toggleGPS.GetComponent<ToggleGroup>(). = false;
		}
		else if (!usingGPS && set) {
			usingGPS = true;
			togglePreset.isOn = false;
		}

	}
	*/
}
