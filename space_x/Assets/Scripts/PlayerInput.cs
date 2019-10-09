using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 public class PlayerInput : MonoBehaviour
{
    [SerializeField] Laser[] laser;
 Transform myT;
 void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            foreach(Laser l in laser)
            {
                Vector3 pos = myT.position + (Vector3.up * l.Distance);
                l.FireLaser(pos);
            }
        }
    }
}
