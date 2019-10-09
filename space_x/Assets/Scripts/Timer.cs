using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {
   [SerializeField]Text timerText;
   [SerializeField]float timePassed;
   bool keepTime = false;

   void OnEnable()
   {
   EventManager.onStartGame += StartTimer;
   EventManager.onPlayerDeath += StopTimer;
   }

   void onDisable()
   {
   EventManager.onStartGame -= StartTimer;
   EventManager.onPlayerDeath -= StopTimer;    
   }

   void Update()
   {
       if(keepTime)
	   {
	   timePassed += Time.deltaTime;
	   UpdateTimerDisplay();
	   }
   }
    void StartTimer()
    { 
	   timePassed = 0;
	   keepTime = true;
	}
	 
	 void StopTimer()
	 {
	    keepTime=false;
	 }

	 void UpdateTimerDisplay()
	 {
	     int minutes;
		 float seconds;
		  minutes = Mathf.FloorToInt(timePassed/60);
		  seconds = timePassed%60;
		  Debug.Log(minutes);
		  timerText.text = string.Format("{0}:{1:00.00}", minutes, seconds);
	 }
}
