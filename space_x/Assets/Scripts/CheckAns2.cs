using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class CheckAns2 : MonoBehaviour
{
    public InputField iF;
    public string ans2;
    //public string myText;

    public void LoadSceneSelect()
    {
        Debug.Log(iF.text);
        ans2 = iF.text;

        if (ans2 == "0 0")
        {
            Debug.Log("Correct!");
            SceneManager.LoadScene(2);

        }
        else
        {
            Debug.Log("Incorrect!");
        }
    }
}

