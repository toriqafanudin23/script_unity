using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balokJaringRotasi2 : MonoBehaviour
{
	public AudioSource audioBerubah;
	public AudioClip clipBerubah;
    public GameObject objek1;
    public GameObject objek2;
    public GameObject objek3;
    public GameObject objek4;
    public GameObject objek5;

    public void tutupJaring()
    {
		audioBerubah.PlayOneShot(clipBerubah);
        objek1.transform.Rotate(Vector3.left, 10f);
        objek2.transform.Rotate(Vector3.down, 10f);
        objek3.transform.Rotate(Vector3.up, 10f);
        objek4.transform.Rotate(Vector3.up, 10f);
        objek5.transform.Rotate(Vector3.right, 10f);
    }
	
	public void bukaJaring()
    {
		audioBerubah.PlayOneShot(clipBerubah);
        objek1.transform.Rotate(Vector3.right, 10f);
        objek2.transform.Rotate(Vector3.up, 10f);
        objek3.transform.Rotate(Vector3.down, 10f);
        objek4.transform.Rotate(Vector3.down, 10f);
        objek5.transform.Rotate(Vector3.left, 10f);
    }
}
