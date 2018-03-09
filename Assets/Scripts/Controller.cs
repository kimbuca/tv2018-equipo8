using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
	
	public SteamVR_Controller.Device device;
	public SteamVR_Controller.Device device2;
	public bool shake = false;

	void FixedUpdate() {
		device = SteamVR_Controller.Input(4);
		device2 = SteamVR_Controller.Input(3);
	}

	// Use this for initialization
	void Start () {
		
	}

	void rumbleController () {
		if(shake){
			device.TriggerHapticPulse (5000, Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad);
			device2.TriggerHapticPulse (5000, Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad);
		}
	}

	// Update is called once per frame
	void Update () {
		rumbleController ();
	}
}
