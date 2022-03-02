using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene1Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        //public Text Char1name;
        public Text Char1speech;
        //public Text Char2name;
        //public Text Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        //public GameObject ArtChar1;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
		public GameObject Choice1c;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
		public GameObject NextScene3Button;
        public GameObject nextButton;
		public string playerName;
		public GameHandler gameHandler;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        //ArtChar1.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice1c.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
		NextScene3Button.SetActive(false);
        nextButton.SetActive(true);
		string pNameTemp = gameHandler.GetName();
		playerName = pNameTemp.ToUpper();
   }

void Update(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       talking();
                }
        }
   }

//Story Units:
public void talking(){         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
                DialogueDisplay.SetActive(true);
                Char1speech.text = "It's the first day of school. Unlike the other years, you're stuck in a brand new place with no friends or allies.";
        }
       else if (primeInt ==3){
                Char1speech.text = "Your parents spent a lot of money to send you to the prestigious Academy of Brimmingham.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1speech.text = "As you walk by, a few students stop to stare.";
        }
       else if (primeInt == 5){
                Char1speech.text = "Finally, you arrive in front of the door to your classroom.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1speech.text = "Before you enter, your stomach growls in hunger. You were rushed out of the house before having any breakfast.";
        }
       else if (primeInt ==7){
                Char1speech.text = "You let out a sigh. You decide your next destination.";
        }
		else if (primeInt ==8){
				nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
				Choice1c.SetActive(true);
		
		}

// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
				nextButton.SetActive(false);
                allowSpace = false;
				NextScene1Button.SetActive(true);
        }
        
       else if (primeInt == 200){
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
       else if (primeInt == 300){
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene3Button.SetActive(true);
        }
}


// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1speech.text = "You decide to stick around outside the classroom to get a feel for who your classmates might be.";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1speech.text = "Your hunger wins out this time. You head towards the cafeteria where you can smell the scent of breakfast.";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice1cFunct(){
                Char1speech.text = "Guilt bubbles in your stomach as you remember the cost of tuition. You head inside the classroom to be a good student.";
                primeInt = 299;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene2A");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2B");
        }
		public void SceneChange3(){
                SceneManager.LoadScene("Scene2C");
        }
}
