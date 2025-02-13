using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soal2pilihan : MonoBehaviour
{
	public AudioSource audioBerubah;
	public AudioClip clipBerubah;
	public GameObject pilihan1, pilihan2, pilihan3, pilihan4;
	public void jawaban1(){
		audioBerubah.PlayOneShot(clipBerubah);
		pilihan1.SetActive(true);
		pilihan2.SetActive(false);
		pilihan3.SetActive(false);
		pilihan4.SetActive(false);
	}
	public void jawaban2(){
		audioBerubah.PlayOneShot(clipBerubah);
		pilihan1.SetActive(false);
		pilihan2.SetActive(true);
		pilihan3.SetActive(false);
		pilihan4.SetActive(false);
	}
	public void jawaban3(){
		audioBerubah.PlayOneShot(clipBerubah);
		pilihan1.SetActive(false);
		pilihan2.SetActive(false);
		pilihan3.SetActive(true);
		pilihan4.SetActive(false);
	}
	public void jawaban4(){
		audioBerubah.PlayOneShot(clipBerubah);
		pilihan1.SetActive(false);
		pilihan2.SetActive(false);
		pilihan3.SetActive(false);
		pilihan4.SetActive(true);
	}
}
