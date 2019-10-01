using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameUI : MonoBehaviour
{   bool isDisplayed=false; 
    [SerializeField]GameObject playButton;
    void OnEnable(){
         EventManager.onStartGame+=HidePanel;
       
}
      void OnDisable(){
          EventManager.onStartGame -=HidePanel;
      }
     void HidePanel(){

            isDisplayed=!isDisplayed;

            playButton.SetActive(isDisplayed);

           if(isDisplayed){
                playButton.SetActive(false);
           }
         else{
             playButton.SetActive(true);
         }
     }
           public void PlayGame(){
               EventManager.StartGame();
 

           }
}