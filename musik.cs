using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musik : MonoBehaviour
{
    public GameObject objekHilang;
    public GameObject objekMuncul;
    public AudioSource audioSource;
    public AudioClip clip;

    // Fungsi untuk menyembunyikan objek dan memainkan clip
    public void putarMusik()
    {
        // Menonaktifkan objekHilang dan mengaktifkan objekMuncul
        objekMuncul.SetActive(false);
        objekHilang.SetActive(true);

        // Memainkan suara
        audioSource.PlayOneShot(clip);
    }

    // Fungsi untuk menyembunyikan objek dan menghentikan clip
    public void stopMusik()
    {
        // Menonaktifkan objekHilang dan mengaktifkan objekMuncul
        objekHilang.SetActive(false);
        objekMuncul.SetActive(true);

        // Menghentikan pemutaran suara
        audioSource.Stop();
    }
}
