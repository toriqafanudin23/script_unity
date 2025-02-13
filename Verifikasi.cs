using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Pastikan Anda menambahkan ini untuk InputField

public class Verifikasi : MonoBehaviour
{
    public GameObject objekHilang, objekMuncul;
    public AudioSource audioSource;
    public AudioClip clip;
    public InputField kode; // Ganti inputfield menjadi InputField
	public GameObject peringatan, kamera, obj_soal;

    public void SubmitKode()
    {
        // Periksa apakah kode yang dimasukkan sesuai
        if (kode.text.Trim() == "uh678") // Gunakan == untuk membandingkan string
        {
            objekHilang.SetActive(false); // Sembunyikan objek
            objekMuncul.SetActive(true);  // Tampilkan objek
            audioSource.PlayOneShot(clip);      // Putar audio
			kamera.SetActive(true);
			obj_soal.SetActive(true);
        } else {
			peringatan.SetActive(true);
		}
    }
}
