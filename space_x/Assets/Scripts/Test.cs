using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void Start()
	{
	Helper.CreatePlane(5,13,true);
	Helper.CreatePlane(13,5,false);
	Debug.Log("Reached");
	}
}
