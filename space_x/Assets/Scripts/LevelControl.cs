using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class LevelControl : MonoBehaviour
{
   public void LoadSceneSelect()
    {
      //  if(Input.GetKeyDown(KeyCode.Space))
        SceneManager.LoadScene(2);
    }
}

