using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class input2 : MonoBehaviour
{
	public InputField jawaban1, jawaban2;
	public GameObject submit;
	public AudioSource audioSalah, audioBenar;
	public AudioClip clipSalah, clipBenar;
	public string kunci1, kunci2;
	public void CheckAnswer1()
    {
        string userAnswer1 = jawaban1.text;
		string userAnswer2 = jawaban2.text;

        if ((userAnswer1 == kunci1) & (userAnswer2 == kunci2))
        {
			submit.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
        }else{
			audioSalah.PlayOneShot(clipSalah);
		}
    }
}
