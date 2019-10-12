using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameBrain : MonoBehaviour
{
  
        
		 
		 public GameObject asteroidOriginal;
         public GameObject asteroidContainer;

    void Start()
    {
        CreateAsteroids(100);
    }

    void CreateAsteroids(int asteroidsNum)
    {
        for (int i = 0; i < asteroidsNum; i++)
        {
            
            GameObject AsteroidClone = Instantiate(asteroidOriginal, new Vector3(i * 0.6f, asteroidOriginal.transform.position.y, i * 0.75f), asteroidOriginal.transform.rotation);
            
            AsteroidClone.transform.parent = asteroidContainer.transform;
			AsteroidClone.name = "AsteroidClone-" + (i + 1);
        }
    }
    
}
