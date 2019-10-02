using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    [SerializeField]int maxHealth = 10;
	[SerializeField]int curHealth;
	[SerializeField]float regenerateAmount =1;
	  
	 void Start()
	 {
	 	 curHealth =maxHealth;
	 }
}
