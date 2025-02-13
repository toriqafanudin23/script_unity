using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hitungKubusSatuan : MonoBehaviour
{
	public InputField jawaban1, jawaban2;
	public GameObject submit1, submit2, home, prev, next;
	public AudioSource audioSalah, audioBenar;
	public AudioClip clipSalah, clipBenar;
	bool cek1 = false;
	bool cek2 = false;
	public string kunci1, kunci2;
	public void kumpulkan1(){
		string userAnswer1 = jawaban1.text;

        if (userAnswer1 == kunci1){
			cek1 = true;
			submit1.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
		}else{
			audioSalah.PlayOneShot(clipSalah);
		}
		
		if (cek1 && cek2){
			home.SetActive(true);
			prev.SetActive(true);
			next.SetActive(true);
		}
	}
	public void kumpulkan2(){
		string userAnswer2 = jawaban2.text;

        if (userAnswer2 == kunci2){
			cek2 = true;
			submit2.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
		}else{
			audioSalah.PlayOneShot(clipSalah);
		}
		
		if (cek1 && cek2){
			home.SetActive(true);
			prev.SetActive(true);
			next.SetActive(true);
		}
	}
}
