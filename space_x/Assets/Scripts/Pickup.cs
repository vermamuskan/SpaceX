using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[DisallowMultipleComponent]
[RequireComponent(typeof(CapsuleCollider))]
public class Pickup : MonoBehaviour
{
static int points=100;
bool gotHit = false;
[SerializeField]float rotationOffset=100f;
 Transform myT;
 
 Vector3 randomRotation;
  void Awake()
  {
     myT=transform; 
  }
  void start(){
  
         randomRotation.x = Random.Range(-rotationOffset, rotationOffset);
         randomRotation.y = Random.Range(-rotationOffset, rotationOffset);
         randomRotation.z = Random.Range(-rotationOffset, rotationOffset);
  
  }
  void Update()
   {
   myT.Rotate(randomRotation* Time.deltaTime);
   }
   void OnTriggerEnter(Collider col)
   {
    if(col.transform.CompareTag("Player"))
	if(!gotHit)
		//gotHit=true;
		PickupHit();
   }
   public void PickupHit()
   {
       if(!gotHit)
	   {
	      gotHit = true;
   	      Debug.Log("hit");
		  EventManager.ReSpawnPickup();
		  Destroy(gameObject);
	   }
   }

}