using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship : MonoBehaviour
{static int count=0;
public GameObject explosion;

   private void OnTriggerEnter2D(Collider2D other)
   {
   //int count=0;
   Debug.Log("hit detected");
	   GameObject e= Instantiate(explosion) as GameObject;
	   e.transform.position =transform.position;
	     Destroy(other.gameObject);
      if(count==3)
	  {
	   this.gameObject.SetActive(false);
	   }
	      	  	   count++;
				   
	    

	   
	   
   }
}
