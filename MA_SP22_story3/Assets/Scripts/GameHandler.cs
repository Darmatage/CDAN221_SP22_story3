using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class GameHandler : MonoBehaviour{
		public static string playerName = "YOU";
        public static int playerStat = 0;
        //public GameObject textGameObject;

        //void Start () { UpdateScore (); }
		
		public static bool hadArgument = false;
		public static bool haveDate = false;
		
       public static bool GameisPaused = false;
        public GameObject pauseMenuUI;
        public AudioMixer mixer;
        public static float volumeLevel = 1.0f;
        private Slider sliderVolumeCtrl;

        void Awake (){
                SetLevel (volumeLevel);
                GameObject sliderTemp = GameObject.FindWithTag("PauseMenuSlider");
                if (sliderTemp != null){
                        sliderVolumeCtrl = sliderTemp.GetComponent<Slider>();
                        sliderVolumeCtrl.value = volumeLevel;
                }
        }

        void Start (){
                pauseMenuUI.SetActive(false);
				playerStat = 0;
				
			UpdateArgument(hadArgument);
			UpdateDate(haveDate);
				
        }

        void Update (){
                if (Input.GetKeyDown(KeyCode.Escape)){
                        if (GameisPaused){
                                Resume();
                        }
                        else{
                                Pause();
                        }
                }
        }

        void Pause(){
                pauseMenuUI.SetActive(true);
                Time.timeScale = 0f;
                GameisPaused = true;
        }

        public void Resume(){
                pauseMenuUI.SetActive(false);
                Time.timeScale = 1f;
                GameisPaused = false;
        }

        public void SetLevel (float sliderValue){
                mixer.SetFloat("MusicVolume", Mathf.Log10 (sliderValue) * 20);
                volumeLevel = sliderValue;
        }

        public void UpdatePlayerStat(int amount){
                playerStat += amount;
                Debug.Log("Current Player Stat = " + playerStat);
        //      UpdateScore ();
        }

        public int CheckPlayerStat(){
                return playerStat;
        }

        //void UpdateScore () {
        //        Text scoreTemp = textGameObject.GetComponent<Text>();
        //        scoreTemp.text = "Score: " + score; }

        public void StartGame(){
                SceneManager.LoadScene("Scene1");
        }
        
		
		public void Credits(){
                SceneManager.LoadScene("Credits");
        }
		
		
        public void RestartGame(){
				playerStat = 0;
				Time.timeScale = 1f;
                SceneManager.LoadScene("MainMenu");
        }

        public void QuitGame(){
                #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
                #else
                Application.Quit();
                #endif
        }
		public void UpdateName(string newName){
            playerName = newName;
            Debug.Log("name changed to " + playerName);
      }
      public string GetName(){
            return playerName;
      }
	  
	  public void UpdateDate(bool dateBool){
		  haveDate = dateBool;
	  }
	  public void UpdateArgument(bool argumentBool){
		  hadArgument = argumentBool;
	  }
	  public bool IsArugment(){
		  return hadArgument;
	  }
	  public bool IsDate(){
		  return hadArgument;
	  }
}