﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CheckAns1 : MonoBehaviour
{
    public InputField iField;
    public string ans;
    //public string myText;

    public void LoadSceneSelect()
    {
        Debug.Log(iField.text);
        ans = iField.text;

        if (ans == "120 200 14")
        {
            Debug.Log("Correct!");
            SceneManager.LoadScene(1);

        }
        else
        {
            Debug.Log("Incorrect!");
        }
    }
}
