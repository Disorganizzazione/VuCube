using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using UnityEngine.Video;
using UnityEngine.UI;


public class PlayButton : MonoBehaviour,  IVirtualButtonEventHandler{
	private GameObject VideoB;
	private VideoPlayer video;
	private GameObject play, pause;
	private AudioSource audio;
	void Start () {
		audio = gameObject.AddComponent<AudioSource>();
		VideoB = GameObject.Find ("Play/Pause");
		play = GameObject.Find ("play");
		pause = GameObject.Find ("pause");
		video = (VideoPlayer) VideoPlayer.FindObjectOfType (typeof(VideoPlayer));
		//gameObject.GetComponent(typeof(VideoPlayer)) as VideoPlayer;
		VideoB.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
		video.SetTargetAudioSource(0, audio);
		video.Stop();
	}

	public void OnButtonPressed(VirtualButtonAbstractBehaviour a){
		if (video.isPlaying) {
			Debug.Log ("Pausa!");
			play.SetActive (true);
			pause.SetActive (false);
			video.Pause ();
		} else {
			Debug.Log ("Play!");
			play.SetActive (false);
			pause.SetActive (true);
			video.Play ();
		}
	}
	public void OnButtonReleased(VirtualButtonAbstractBehaviour b){
		
	}

}
