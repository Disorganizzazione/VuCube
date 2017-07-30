using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class gitvbut : MonoBehaviour,  IVirtualButtonEventHandler{
	private GameObject gitB;
	// Use this for initialization
	void Start () {
		gitB = GameObject.Find ("gitB");
		gitB.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
	}

	public void OnButtonPressed(VirtualButtonAbstractBehaviour a){
		Application.OpenURL("https://www.github.com/Disorganizzazione/VuCube");
		//System.Diagnostics.Process.Start("https://www.unistudium.unipg.it/unistudium");
	}
	public void OnButtonReleased(VirtualButtonAbstractBehaviour b){

	}

}