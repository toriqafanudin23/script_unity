using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gantiPrisma : MonoBehaviour
{
	public AudioSource audioBerubah;
	public AudioClip clipBerubah;
	public GameObject prisma1,prisma2,prisma3,prisma4;
	int angka = 0;
	public void ganti(){
		audioBerubah.PlayOneShot(clipBerubah);
		angka++;
		if (angka % 4 == 1){
			prisma1.SetActive(false);
			prisma2.SetActive(true);
		}
		if (angka % 4 == 2){
			prisma2.SetActive(false);
			prisma3.SetActive(true);
		}
		if (angka % 4 == 3){
			prisma3.SetActive(false);
			prisma4.SetActive(true);
		}
		if (angka % 4 == 0){
			prisma4.SetActive(false);
			prisma1.SetActive(true);
		}
	}
}
