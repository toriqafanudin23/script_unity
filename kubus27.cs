using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kubus27 : MonoBehaviour
{
	public AudioSource audioBerubah;
	public AudioClip clipBerubah;
    public GameObject c1,c2,c3,c4,c5,c6,c7,c8,c9,c10,c11,c12,c13,c14,c15,c16,c17,c18,c19,c20,c21,c22,c23,c24,c25,c26,c27;
    GameObject[] kubus;

    void Awake()
    {
        kubus = new GameObject[] {c1,c2,c3,c4,c5,c6,c7,c8,c9,c10,c11,c12,c13,c14,c15,c16,c17,c18,c19,c20,c21,c22,c23,c24,c25,c26,c27};
    }

    int i = 26;

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
		if (i < 26){
			i++;
			kubus[i].SetActive(true);
			audioBerubah.PlayOneShot(clipBerubah);
		}
	}
}
