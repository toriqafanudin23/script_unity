using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class input7 : MonoBehaviour
{
	public InputField jawaban1, jawaban2, jawaban3, jawaban4, jawaban5, jawaban6, jawaban7;
	public GameObject submit;
	public AudioSource audioSalah, audioBenar;
	public AudioClip clipSalah, clipBenar;
	public string kunci1, kunci2, kunci3, kunci4, kunci5, kunci6, kunci7;
	public void CheckAnswer1()
    {
        string userAnswer1 = jawaban1.text;
		string userAnswer2 = jawaban2.text;
		string userAnswer3 = jawaban3.text;
		string userAnswer4 = jawaban4.text;
		string userAnswer5 = jawaban5.text;
		string userAnswer6 = jawaban6.text;
		string userAnswer7 = jawaban7.text;

        if ((userAnswer1 == kunci1) & ((userAnswer2 == kunci2)) & ((userAnswer3 == kunci3)) & ((userAnswer4 == kunci4)) & ((userAnswer5 == kunci5)) & ((userAnswer6 == kunci6)) & ((userAnswer7 == kunci7)))
        {
			submit.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
        }else{
			audioSalah.PlayOneShot(clipSalah);
		}
    }
}
