using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GoBack : MonoBehaviour {
	
	public Button button;
	public GameObject panel;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
	
	}

	public void goBackToGPS(){
		SceneManager.LoadScene ("Map_GPS", LoadSceneMode.Single);
	}
	public void goBackToChinatown(){
		SceneManager.LoadScene ("Map_Chinatown", LoadSceneMode.Single);
	}
	public void goBackToBeijing(){
		SceneManager.LoadScene ("Map_Beijing", LoadSceneMode.Single);
	}
	public void goToBeijing01(){
		SceneManager.LoadScene ("Image01_Beijing", LoadSceneMode.Single);
	}
	public void goToBeijing02(){
		SceneManager.LoadScene ("Image01_Tiananmen", LoadSceneMode.Single);
	}
	public void goBackHome(){
		SceneManager.LoadScene ("Intro", LoadSceneMode.Single);
	}

	public void closePanel(){
		panel.SetActive (false);
	}

}
