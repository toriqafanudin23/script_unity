using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class input4 : MonoBehaviour
{
	public InputField jawaban1, jawaban2, jawaban3, jawaban4;
	public GameObject submit;
	public AudioSource audioSalah, audioBenar;
	public AudioClip clipSalah, clipBenar;
	public string kunci1, kunci2, kunci3, kunci4;
	public void CheckAnswer1()
    {
        string userAnswer1 = jawaban1.text;
		string userAnswer2 = jawaban2.text;
		string userAnswer3 = jawaban3.text;
		string userAnswer4 = jawaban4.text;

        if ((userAnswer1 == kunci1) & ((userAnswer2 == kunci2)) & ((userAnswer3 == kunci3)) & ((userAnswer4 == kunci4)))
        {
			submit.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
        }else{
			audioSalah.PlayOneShot(clipSalah);
		}
    }
}
