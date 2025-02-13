using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muncul1 : MonoBehaviour
{
	public GameObject objek;
	
	public void muncul()
    {
		objek.SetActive(true);
    }
	
	public void hilang()
    {
		objek.SetActive(false);
    }
}
