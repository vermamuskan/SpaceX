using System.Collections;

using UnityEngine;

public class Asteroid : MonoBehaviour
{

    [SerializeField]float minScale=.10f;
    [SerializeField]float maxScale=1.8f;
    [SerializeField]float rotationOffset=100f;
    [SerializeField]GameObject explosion;
    Transform myT;
    Vector3 randomRotation;
    void Awake()
    {
        myT=transform;
    }
    void Start()
    {
         Vector3 scale=Vector3.one ;
         scale.x=Random.Range(minScale,maxScale);
         scale.y=Random.Range(minScale,maxScale);
         scale.z=Random.Range(minScale,maxScale);
         myT.localScale=scale;

         randomRotation.x = Random.Range(-rotationOffset, rotationOffset);
         randomRotation.y = Random.Range(-rotationOffset, rotationOffset);
         randomRotation.z = Random.Range(-rotationOffset, rotationOffset);
        // Debug.Log(randomRotation);
    } 
    void Update()
    {
         myT.Rotate(randomRotation * Time.deltaTime);
    }

}

