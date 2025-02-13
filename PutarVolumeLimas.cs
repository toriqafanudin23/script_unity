using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PutarVolumeLimas : MonoBehaviour
{
	public AudioSource audioBerubah;
	public AudioClip clipBerubah;
    public GameObject objek1,objek2,objek3,objek4;
	int angka = 0;
    public void bukaJaring()
    {
		if (angka < 15){
			angka++;
			audioBerubah.PlayOneShot(clipBerubah);
			if (angka <= 5){
				objek1.transform.Rotate(Vector3.left, 36f);
			}
			else if (angka <= 10){
				objek2.transform.Rotate(-Vector3.forward, 36f);
			}
			else if (angka <= 15){
				objek3.transform.Rotate(Vector3.left, 18f);
				objek4.transform.Rotate(-Vector3.forward, 18f);
			}
		}
	}
	
	public void tutupJaring()
    {
		if (angka > 0){
			audioBerubah.PlayOneShot(clipBerubah);
			if (angka > 10){
				objek3.transform.Rotate(-Vector3.left, 18f);
				objek4.transform.Rotate(Vector3.forward, 18f);
			}
			else if (angka > 5){
				objek2.transform.Rotate(Vector3.forward, 36f);
			}
			else if (angka > 0){
				objek1.transform.Rotate(-Vector3.left, 36f);
			}
			angka--;
		}
	}
}
