using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameUI : MonoBehaviour
{ 
//  bool isDisplayed=false; 
    [SerializeField]GameObject mainMenu;
	[SerializeField]GameObject gameUI;

	

    void OnEnable()
	{
         EventManager.onStartGame+= ShowGameUI;
		 EventManager.onPlayerDeath += ShowMainMenu;
    }       

      void OnDisable()
	 {
          EventManager.onStartGame -= ShowGameUI;
		  EventManager.onPlayerDeath -= ShowMainMenu;
     }

	  void ShowMainMenu()
	  {
	       mainMenu.SetActive(true);
			gameUI.SetActive(false);
	  }

	  void ShowGameUI()
	  {
	        mainMenu.SetActive(false);
			gameUI.SetActive(true);
	  }
} 