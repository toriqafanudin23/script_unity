using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gantiKubus : MonoBehaviour
{
	public AudioSource audioBerubah;
	public AudioClip clipBerubah;
	public GameObject button22, button33, kubus22, kubus33;
	bool awal = true;
	public void ganti()
	{
		if (awal){
			button22.SetActive(false);
			kubus22.SetActive(false);
			button33.SetActive(true);
			kubus33.SetActive(true);
			awal = false;
		}
		else{
			button22.SetActive(true);
			kubus22.SetActive(true);
			button33.SetActive(false);
			kubus33.SetActive(false);
			awal = true;
		}
		audioBerubah.PlayOneShot(clipBerubah);
	}
}
