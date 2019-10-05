  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    [SerializeField]int maxHealth = 10;
	[SerializeField]int curHealth; 
	  
	 void Start()
	 {
	 	 curHealth =maxHealth;
	 }
	 public void TakeDamage(int dmg = 2)
	 {
	 	 curHealth -= dmg;
		  if(curHealth < 0)
		    curHealth = 0;
			EventManager.TakeDamage(curHealth/(float)maxHealth);
		 if(curHealth < 1)
		   Debug.Log("I B Dead!");
	 }

}
