using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obj : MonoBehaviour
{
	public GameObject objek;
	public void Benda(){
		objek.SetActive(!objek.activeSelf);
	}
}
