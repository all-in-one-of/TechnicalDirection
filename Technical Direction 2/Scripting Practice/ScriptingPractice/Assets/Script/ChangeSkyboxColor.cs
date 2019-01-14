using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkyboxColor : MonoBehaviour
{

	public Color SkyboxColor;

	public void ColorSkybox()
	{
	    //make a random, vector3 value so it can act as the color setting

	    RenderSettings.skybox.SetColor("_Tint", SkyboxColor);
	}
}
