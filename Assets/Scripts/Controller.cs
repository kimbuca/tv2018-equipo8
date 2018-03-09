using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

	public SteamVR_TrackedObject trackedObj;
	public SteamVR_TrackedObject trackedObj2;
	public SteamVR_Controller.Device device;
	public SteamVR_Controller.Device device2;

	void Awake () {
		trackedObj = GetComponent<SteamVR_TrackedObject>();
		trackedObj2 = GetComponent<SteamVR_TrackedObject>();
	}

	void FixedUpdate() {
		device = SteamVR_Controller.Input((int)trackedObj.index);
		device2 = SteamVR_Controller.Input((int)trackedObj2.index);
	}

	// Use this for initialization
	void Start () {
		
	}

	void rumbleController () {
		//if (device.GetPressDown (SteamVR_Controller.ButtonMask.Grip)) {
		device.TriggerHapticPulse (5000, Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad);
		//}
		//if (device2.GetPressDown (SteamVR_Controller.ButtonMask.Grip)) {
		device2.TriggerHapticPulse (5000, Valve.VR.EVRButtonId.k_EButton_SteamVR_Touchpad);
		//}
	}

	// Update is called once per frame
	void Update () {
		rumbleController ();
	}
}
