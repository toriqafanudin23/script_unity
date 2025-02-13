using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class putarBenda : MonoBehaviour
{
	public bool Terputar = false;
	public Vector3 KecepatanPutaran;
	
	void Update(){
		if (Terputar){
			transform.Rotate(
			KecepatanPutaran.x * Time.deltaTime * 10,
			KecepatanPutaran.y * Time.deltaTime * 10,
			KecepatanPutaran.z * Time.deltaTime * 10
			);
		}
	}
	public void putaran(){
		if (Terputar){
			Terputar = false;
		}else{
			Terputar = true;
		}
	}

}
