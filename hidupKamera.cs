using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hidupKamera : MonoBehaviour
{
	public GameObject objek;

    // Fungsi untuk menyembunyikan atau menampilkan objek tergantung pada kondisi
    public void Hide()
    {
        // Menonaktifkan atau mengaktifkan objek berdasarkan kondisi
        if (objek.activeSelf == true)
        {
            objek.SetActive(false);
        }
        else
        {
            objek.SetActive(true);
        }
    }
}
