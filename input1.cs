using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class input1 : MonoBehaviour
{
	public InputField jawaban1;
	public GameObject submit;
	public AudioSource audioSalah, audioBenar;
	public AudioClip clipSalah, clipBenar;
	public string kunci1;
	public void CheckAnswer1()
    {
        string userAnswer1 = jawaban1.text;

        if (userAnswer1 == kunci1)
        {
			submit.SetActive(false);
			audioBenar.PlayOneShot(clipBenar);
        }else{
			audioSalah.PlayOneShot(clipSalah);
		}
    }
}