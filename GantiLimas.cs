using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GantiLimas : MonoBehaviour
{
	public AudioSource audioBerubah;
	public AudioClip clipBerubah;
	public GameObject prisma1,prisma2,prisma3;
	int angka = 0;
	public void ganti(){
		audioBerubah.PlayOneShot(clipBerubah);
		angka++;
		if (angka % 3 == 1){
			prisma1.SetActive(false);
			prisma2.SetActive(true);
		}
		if (angka % 3 == 2){
			prisma2.SetActive(false);
			prisma3.SetActive(true);
		}
		if (angka % 3 == 0){
			prisma3.SetActive(false);
			prisma1.SetActive(true);
		}
	}
}
