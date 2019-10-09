using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(LineRenderer))]
public class Laser : MonoBehaviour
{
    [SerializeField]float laserOffTime = 0.5f;
    [SerializeField]float maxDistance = 300f;
    Light laserLight;
    LineRenderer lr;
    bool canFire;
    void Awake()
    {
        lr = GetComponent<LineRenderer>();
        laserLight = GetComponent<Light>();
    }
    void Start()
    {
        lr.enabled = false;
        laserLight.enabled = false;
		canFire = true;
    }
    /*
    void Update(){
        FireLaser(transform.forward*maxDistance);
    }
    */
    Vector3 CastRay()
    {  
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward) * maxDistance;
        if (Physics.Raycast(transform.position, fwd, out hit))
        {
            Debug.Log("We hit : " + hit.transform.name);
			
		//	Explosion temp= hit.transform.GetComponent<Explosion>();
		
		// if(temp!=null)
		//temp.IveBeenHit(hit.point);
			SpawnExplosion(hit.point,hit.transform);
			if(hit.transform.CompareTag("Pickup"))
			hit.transform.GetComponent<Pickup>().PickupHit();
            return hit.point;
        }
            Debug.Log("We missed....");
            return transform.position + (Vector3.up * maxDistance);
    }
    void SpawnExplosion(Vector3 hitPosition , Transform target){
		            Explosion temp = target.GetComponent<Explosion>();
            if (temp != null)
              //  temp.IveBeenHit(hitPosition);
				temp.AddForce(hitPosition,transform);
	}
 public void FireLaser()
 {
 	 Vector3 pos = CastRay();
	 FireLaser(pos);
 }
    public void FireLaser(Vector3 targetPosition,Transform target= null)
    {
        if (canFire)
        {   SpawnExplosion(targetPosition,target);}
            lr.SetPosition(0, transform.position);
            lr.SetPosition(1, targetPosition);
            lr.enabled = true;
            laserLight.enabled = true;
            canFire = false;
        Invoke("TurnOffLaser", laserOffTime);
	//	Invoke("CanFire", fireDelay);
    }
    void TurnOffLaser()
    {
        lr.enabled = false;
        laserLight.enabled = false;
        canFire = true;
    }
    public float Distance{ get { return maxDistance; } }

}
