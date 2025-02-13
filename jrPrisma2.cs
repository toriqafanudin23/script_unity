using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jrPrisma2 : MonoBehaviour
{
	public AudioSource audioBerubah;
	public AudioClip clipBerubah;
    public GameObject objek1;
    public GameObject objek2;
    public GameObject objek3;
    public GameObject objek4;
	public GameObject objek5;
    public GameObject objek6;
    public GameObject objek7;
	float step = 9f;
	float step2 = 6f;

    public void tutupJaring()
    {
		audioBerubah.PlayOneShot(clipBerubah);
        objek1.transform.Rotate(Vector3.down, step);
        objek2.transform.Rotate(Vector3.left, step2);
        objek3.transform.Rotate(Vector3.right, step2);
        objek4.transform.Rotate(Vector3.up, step);
		objek5.transform.Rotate(Vector3.left, step2);
        objek6.transform.Rotate(Vector3.right, step2);
        objek7.transform.Rotate(Vector3.up, step);
    }
	
	public void bukaJaring()
    {
		audioBerubah.PlayOneShot(clipBerubah);
        objek1.transform.Rotate(Vector3.up, step);
        objek2.transform.Rotate(Vector3.right, step2);
        objek3.transform.Rotate(Vector3.left, step2);
        objek4.transform.Rotate(Vector3.down, step);
		objek5.transform.Rotate(Vector3.right, step2);
        objek6.transform.Rotate(Vector3.left, step2);
        objek7.transform.Rotate(Vector3.down, step);
    }
}
