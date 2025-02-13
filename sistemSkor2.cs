using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sistemSkor2 : MonoBehaviour
{
	public InputField h5k1,h5k2,h9k1,h9k2,h11k1,h11k2,h16k1,h16k2,h16k3,h16k4,h16k5,h16k6,h16k7,
						h21k1,h21k2,h21k3,h21k4,h21k5,h21k6;
	public Text skorText;
	public GameObject submit1, submit2,submit3,submit4,submit5;
	
	public AudioSource audioSalah, audioBenar;
	public AudioClip clipSalah, clipBenar;
	
	private int skor = 0;
	
	public void halaman5(){
		string userAnswer1 = h5k1.text;
		string userAnswer2 = h5k2.text;

        if ((userAnswer1 == "27")&&(userAnswer2 == "64")){
			skor += 2;
			string skorString = skor.ToString();
            skorText.text = skorString;
			audioBenar.PlayOneShot(clipBenar);
			submit1.SetActive(false);
		}else{
			audioSalah.PlayOneShot(clipSalah);
		}
	}
	
	public void halaman9(){
		string userAnswer1 = h9k1.text;
		string userAnswer2 = h9k2.text;

        if ((userAnswer1 == "8")&&(userAnswer2 == "24")){
			skor += 2;
			string skorString = skor.ToString();
            skorText.text = skorString;
			audioBenar.PlayOneShot(clipBenar);
			submit2.SetActive(false);
		}else{
			audioSalah.PlayOneShot(clipSalah);
		}
	}
	
	public void halaman11(){
		string userAnswer1 = h11k1.text;
		string userAnswer2 = h11k2.text;

        if ((userAnswer1 == "343")&&(userAnswer2 == "672")){
			skor += 2;
			string skorString = skor.ToString();
            skorText.text = skorString;
			audioBenar.PlayOneShot(clipBenar);
			submit3.SetActive(false);
		}else{
			audioSalah.PlayOneShot(clipSalah);
		}
	}
	
	public void halaman16(){
		string userAnswer1 = h16k1.text;
		string userAnswer2 = h16k2.text;
		string userAnswer3 = h16k3.text;
		string userAnswer4 = h16k4.text;
		string userAnswer5 = h16k5.text;
		string userAnswer6 = h16k6.text;
		string userAnswer7 = h16k7.text;

        if ((userAnswer1 == "3")&&(userAnswer2 == "4")&&(userAnswer3 == "6")&&(userAnswer4 == "6")&&(userAnswer5 == "6")&&(userAnswer6 == "36")&&(userAnswer7 == "36")){
			skor += 7;
			string skorString = skor.ToString();
            skorText.text = skorString;
			audioBenar.PlayOneShot(clipBenar);
			submit4.SetActive(false);
		}else{
			audioSalah.PlayOneShot(clipSalah);
		}
	}
	
	public void halaman21(){
		string userAnswer1 = h21k1.text;
		string userAnswer2 = h21k2.text;
		string userAnswer3 = h21k3.text;
		string userAnswer4 = h21k4.text;
		string userAnswer5 = h21k5.text;
		string userAnswer6 = h21k6.text;

        if ((userAnswer1 == "2")&&(userAnswer2 == "7")&&(userAnswer3 == "7")&&(userAnswer4 == "6")&&(userAnswer5 == "42")&&(userAnswer6 == "42")){
			skor += 6;
			string skorString = skor.ToString();
            skorText.text = skorString;
			audioBenar.PlayOneShot(clipBenar);
			submit5.SetActive(false);
		}else{
			audioSalah.PlayOneShot(clipSalah);
		}
	}
}
