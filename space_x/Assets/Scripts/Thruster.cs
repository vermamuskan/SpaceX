using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TrailRenderer))]
public class Thruster : MonoBehaviour {
TrailRenderer tr;
  void Awake()
  {
    tr =GetComponent<TrailRenderer>();
  }
 public void Activate(bool activate = true)
 {
     if(activate)
     {
        tr.enabled=true;
        //turn on partial effects
        //turn on sound
       //etc
     }
     else
     {
       tr.enabled=false;
       //turn off anything associate with thrusting
     }
  }
}

