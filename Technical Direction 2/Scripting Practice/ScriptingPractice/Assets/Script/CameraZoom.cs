using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoom : MonoBehaviour {

	//Regular Field of View in the Inspector shows the camera, at it's default setting, is at 60.
	int camNorm = 60;
	//Field of View Variable that will change when certain buttons are hit. 
	int camZoom = 30;
	//How smoothly the camera will change it's FOV. Eventually this will be multiplied by time.deltaTime
	float camSmooth = 10;
	//The "switch" for determining if the camera is using it's "zoom" feature or not.
	private bool camZoomCheck = false;

	// Update is called once per frame
	// Maybe Romrell will know a way to optimize the script?
	void Update () 
	{
			//If The Control key and the Mouse button are held down, the camera "will be zoomed in"
			if (Input.GetKey(KeyCode.LeftControl) && Input.GetMouseButton(1))
			{
				camZoomCheck = true;
			} //If the Control Key or the Mouse button are release, the camera "will not be zoomed in"
			if (Input.GetKeyUp(KeyCode.LeftControl) || Input.GetMouseButtonUp(1))
			{
				camZoomCheck = false;
			}
			//If the zoom feature of the camera is active, then the camera will zoom in. 
			if (camZoomCheck)
			{
				//Gets the component From the Camera feature on the Main Camera. 
				//Then it grabs the "fieldOfView" setting on the camera.
				//The original field of view will then change slowly (this is the Mathf.Lerp feature)
					//Mathf is "a collection of common math functions"
					//https://docs.unity3d.com/ScriptReference/Mathf.html
					//the Lerp method in Mathf linearly interpolates between 'a' and 'b' by 't'
						//'a' is the start value, 'b' is the end value, and 't' is the interpolation between the floats
				//Long story short, the method on the right will slowly change the field of View 
					//In this case, the method takes the value of the camera's initial fieldOfView, 
					//states it wants to go to the 'camZoom' FOV,
					//and then how fast the camera will move from point 'a' to point 'b'
				GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, camZoom, Time.deltaTime * camSmooth);
			}
			else //When the zoom feature is not active in the camera, the camera will go back to it's original field of view. 
			{
				//Similar to the function above, this will change the original FOV of the camera to the FOV in 'camNorm', and will do it at the same rate. 
				GetComponent<Camera>().fieldOfView = Mathf.Lerp(GetComponent<Camera>().fieldOfView, camNorm, Time.deltaTime * camSmooth);
			}
	}
}
