using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kubus8 : MonoBehaviour
{
	public AudioSource audioBerubah;
	public AudioClip clipBerubah;
    public GameObject c1, c2, c3, c4, c5, c6, c7, c8;
    GameObject[] kubus;

    void Awake()
    {
        kubus = new GameObject[] { c1, c2, c3, c4, c5, c6, c7, c8 };
    }

    int i = 7;

    public void kurang()
    {
		if (i > 0){
			kubus[i].SetActive(false);
		i--;
		audioBerubah.PlayOneShot(clipBerubah);
		}
    }
	public void tambah()
	{
		if (i < 7){
			i++;
			kubus[i].SetActive(true);
			audioBerubah.PlayOneShot(clipBerubah);
		}
	}
}
