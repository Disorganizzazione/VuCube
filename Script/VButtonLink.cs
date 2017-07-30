using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VButtonLink : MonoBehaviour,  IVirtualButtonEventHandler{
	private GameObject linkB;
	// Use this for initialization
	void Start () {
		linkB = GameObject.Find ("linkB");
		linkB.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
	}

	public void OnButtonPressed(VirtualButtonAbstractBehaviour a){
		Application.OpenURL("https://www.unistudium.unipg.it/unistudium");
		//System.Diagnostics.Process.Start("https://www.unistudium.unipg.it/unistudium");
	}
	public void OnButtonReleased(VirtualButtonAbstractBehaviour b){
		
	}
		
}