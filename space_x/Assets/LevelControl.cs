using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class LevelControl : MonoBehaviour
{
   void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        SceneManager.LoadScene(1);
    }
}

