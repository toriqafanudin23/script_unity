using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hilangObjek : MonoBehaviour
{
	public GameObject objekHilang, objekMuncul;
	public AudioSource audioSource;
	public AudioClip clip;

    // Fungsi untuk menyembunyikan objek
    public void Hide()
    {
        // Menonaktifkan objek untuk menyembunyikannya
        objekHilang.SetActive(false);
		objekMuncul.SetActive(true);
		audioSource.PlayOneShot(clip);
    }
}
