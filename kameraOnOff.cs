using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraOnOff : MonoBehaviour
{
	public GameObject mainKamera;
	public void ToggleCamera()
	{
		if (mainKamera != null)
		{
			mainKamera.SetActive(!mainKamera.activeSelf);
		}
	}
}
