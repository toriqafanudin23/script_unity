using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gantiJaringKubus : MonoBehaviour
{
	public AudioSource audioBerubah;
	public AudioClip clipBerubah;
	public GameObject jaring1,jaring2,jaring3,jaring4;
	public GameObject net1,net2,net3,net4;
	int angka = 0;
	public void ganti(){
		audioBerubah.PlayOneShot(clipBerubah);
		angka++;
		if (angka % 4 == 1){
			jaring1.SetActive(false);
			jaring2.SetActive(true);
			net1.SetActive(false);
			net2.SetActive(true);
		}
		if (angka % 4 == 2){
			jaring2.SetActive(false);
			jaring3.SetActive(true);
			net2.SetActive(false);
			net3.SetActive(true);
		}
		if (angka % 4 == 3){
			jaring3.SetActive(false);
			jaring4.SetActive(true);
			net3.SetActive(false);
			net4.SetActive(true);
		}
		if (angka % 4 == 0){
			jaring4.SetActive(false);
			jaring1.SetActive(true);
			net4.SetActive(false);
			net1.SetActive(true);
		}
	}
}
