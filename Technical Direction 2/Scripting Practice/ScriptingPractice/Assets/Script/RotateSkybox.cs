using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSkybox : MonoBehaviour {

public bool setRot = false;
public float rotSpeed = 0.3f;


    //If setRot is true, the Sky will spin.
    public void Update()
    {
        if (setRot == true)
            RenderSettings.skybox.SetFloat("_Rotation", rotSpeed*Time.time);
    }

    //If button is pushed, it changes the value of setRot
    public void ToggleSkyRotation()
    {
        setRot = !setRot;
    }
}
