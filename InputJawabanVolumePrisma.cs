using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputJawabanVolumePrisma : MonoBehaviour
{
	public InputField j1,j2,j3,j4,j5,j6,j7,j8,j9,j10,j11,j12,j13,j14,j15;
	public GameObject s1,s2,s3,s4,s5,s6,s7,s8,s9,s10;
	public string k1,k2,k3,k4,k5,k6,k7,k8,k9,k10,k11,k12,k13,k14,k15;
	public Text t1,t2,t3,t4;
	public AudioSource audioSalah, audioBenar;
	public AudioClip clipSalah, clipBenar;
	public void CekJawaban1(){
		string userAnswer = j1.text;
		string userAnswer2 = j2.text;

        if ((userAnswer == k1)&&(userAnswer2 == k2)){
			s1.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
		}else{
			audioSalah.PlayOneShot(clipSalah);
		}
	}
	
	public void CekJawaban2(){
		string userAnswer = j3.text;
		if (userAnswer == k3){
			s2.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
			t1.text = "42";
		}else{
			audioSalah.PlayOneShot(clipSalah);
		}
	}
	
	public void CekJawaban3(){
		string userAnswer = j4.text;
		string userAnswer2 = j5.text;

        if ((userAnswer == k4)&&(userAnswer2 == k5)){
			s3.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
		}else{
			audioSalah.PlayOneShot(clipSalah);
		}
	}
	
	public void CekJawaban4(){
		string userAnswer = j6.text;
		if (userAnswer == k6){
			s4.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
		}else{
			audioSalah.PlayOneShot(clipSalah);
		}
	}
	
	public void CekJawaban5(){
		string userAnswer = j7.text;
		if (userAnswer == k7){
			s5.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
		}else{
			audioSalah.PlayOneShot(clipSalah);
		}
	}
	
	public void CekJawaban6(){
		string userAnswer = j8.text;
		if (userAnswer == k8){
			s6.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
		}else{
			audioSalah.PlayOneShot(clipSalah);
		}
	}
	
	public void CekJawaban7(){
		string userAnswer = j9.text;
		string userAnswer2 = j10.text;
		string userAnswer3 = j11.text;
		if ((userAnswer == k9)&&(userAnswer2 == k10)&&(userAnswer3 == k11)){
			s7.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
		}else{
			audioSalah.PlayOneShot(clipSalah);
		}
	}
	
	public void CekJawaban8(){
		string userAnswer = j12.text;
		if (userAnswer == k12){
			s8.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
			t2.text = "36";
		}else{
			audioSalah.PlayOneShot(clipSalah);
		}
	}
	
	public void CekJawaban9(){
		string userAnswer = j13.text;
		if (userAnswer == k13){
			s9.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
			t3.text = "41,52";
		}else{
			audioSalah.PlayOneShot(clipSalah);
		}
	}
	
	public void CekJawaban10(){
		string userAnswer = j14.text;
		string userAnswer2 = j15.text;
		if ((userAnswer == k14)&&(userAnswer2 == k15)){
			s10.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
			t4.text = "207,6";
		}else{
			audioSalah.PlayOneShot(clipSalah);
		}
	}
}
