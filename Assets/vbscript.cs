using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class vbscript : MonoBehaviour,IVirtualButtonEventHandler{
	public GameObject vbbtn;
	// Use this for initialization
	void Start () {
		vbbtn=gameObject.find("playmusic");
		vbbtn.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
	}
	
	// Update is called once per frame
	public void OnbuttonPressed( VirtualButtonBehaviour vb)
	{
		Debug.Log ("Buttom pressed");
	}
