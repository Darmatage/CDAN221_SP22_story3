using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4ADialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1;
		public GameObject ArtChar2;
		public GameObject ArtChar3;
		public GameObject ArtCharB;
        public GameObject ArtBG1;
		public GameObject ArtBG2;
        public GameObject Choice1a;
        public GameObject Choice1b;
		public GameObject Choice1c;
		public GameObject Choice1d;
        public GameObject NextScene1Button;
        public GameObject nextButton;
		public string playerName;
		//public GameObject gameHandler;
		public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ArtChar1.SetActive(false);
		ArtChar2.SetActive(false);
		ArtChar3.SetActive(false);
		ArtCharB.SetActive(false);
        ArtBG1.SetActive(true);
		ArtBG2.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice1c.SetActive(false);
		Choice1d.SetActive(false);
        NextScene1Button.SetActive(false);
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
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "Before you enter the classroom, you decide to...";
		 }
		 	else if (primeInt == 3){
				Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
		}
		
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
			ArtBG1.SetActive(false);
			ArtBG2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "You enter the classroom, eyes glancing your way. As you take a seat at your desk, there is a bouquet of flowers.";
        }
       else if (primeInt == 101){
				Choice1c.SetActive(true); // function Choice1aFunct()
                Choice1d.SetActive(true); // function Choice1bFunct()
        }
		  else if (primeInt == 200){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "The bell rings. The teacher steps in and begins her lesson.";
        }
		else if (primeInt == 201){
				ArtCharB.SetActive(true);
				Char1name.text = "Mrs. Kane";
				Char1speech.text = "Alright class. Please turn to page 25 of your textbook.";
				Char2name.text = "";
				Char2speech.text = "";
		}
		else if (primeInt == 202){
				ArtCharB.SetActive(false);
				ArtChar3.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "As everyone shuffles to get your books out, the door slides open. Reyes was there with a frown.";
        }
		else if (primeInt == 203){
				ArtCharB.SetActive(true);
				ArtChar3.SetActive(false);
				Char1name.text = "Mrs. Kane";
				Char1speech.text = "Grateful to have you join us, Reyes. Now take your seat and get today's lesson out.";
				Char2name.text = "";
				Char2speech.text = "";
		}
		else if (primeInt == 204){
				ArtCharB.SetActive(false);
				ArtChar3.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Reyes";
				Char2speech.text = "Tsk.";
        }
		else if (primeInt == 205){
				ArtCharB.SetActive(false);
				ArtChar3.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
				Char2speech.text = "Reyes sits in the open seat directly behind your desk.";
				primeInt = 299;
        }
		
		 //if (gameHandler.CheckPlayerStat() <= 1){
               //      primeInt = 299;
		 //}			 
		//else if (primeInt == 206){
			//	Char1name.text = "";
			//	Char1speech.text = "";
			//	Char2name.text = "";
			//	Char2speech.text = "You feel eyes burning a hole in the back of your head as you try and focus on the lesson.";
		//}
		 
		 else if (primeInt == 300){
				ArtCharB.SetActive(false);
				ArtChar3.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
				Char2speech.text = "You feel a tap on your shoulder.";
}
		else if (primeInt == 301){
				ArtChar3.SetActive(false);
				ArtChar1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Reyes";
				Char2speech.text = "I see you got my gift. Not that I care or anything. Just thought of you when I saw it I guess.";
		}
		
		else if (primeInt == 302){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
				Char2speech.text = "Yeah! Thank you. I wish I had something to give back to return the favor.";
		}
		else if (primeInt == 303){
				ArtChar1.SetActive(false);
				ArtChar2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Reyes";
				Char2speech.text = "Don't worry about it. You'll get your chance.";
		}
		else if (primeInt == 304){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
				Char2speech.text = "Before you could question him, Mrs. Kane clears her throat loudly.";
		}
		else if (primeInt == 305){
				ArtCharB.SetActive(true);
				ArtChar2.SetActive(false);
				Char1name.text = "Mrs. Kane";
                Char1speech.text = "Mister Reyes. Did you have something to say to the class? Maybe answering our question here?";
                Char2name.text = "";
				Char2speech.text = "";
		}
		else if (primeInt == 306){
				ArtCharB.SetActive(false);
				ArtChar1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Reyes";
				Char2speech.text = "...";
		}
		else if (primeInt == 307){
				ArtCharB.SetActive(true);
				ArtChar1.SetActive(false);
				Char1name.text = "Mrs. Kane";
                Char1speech.text = "That's what I thought. Detention service after school.";
                Char2name.text = "";
				Char2speech.text = "";
		}
		else if (primeInt == 308){
				ArtCharB.SetActive(false);
				ArtChar3.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Reyes";
				Char2speech.text = "Tsk.";
		}
		else if (primeInt == 309) {
			nextButton.SetActive(false);
                allowSpace = false;
				NextScene1Button.SetActive(true);
		}
		
		
}
// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "You decide to put on your gift.";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
				gameHandler.UpdatePlayerStat(1);
        }
        public void Choice1bFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "At the last moment, you decide to shove the gift into your pocket.";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
				gameHandler.UpdatePlayerStat(-1);
        }
		public void Choice1cFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "You bring the flowers and put it into the trash.";
                primeInt = 199;
                Choice1c.SetActive(false);
                Choice1d.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
				gameHandler.UpdatePlayerStat(-1);
        }
		public void Choice1dFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "You take the bouquet and give it a smell. It smells lovely.";
                primeInt = 199;
                Choice1c.SetActive(false);
                Choice1d.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
				gameHandler.UpdatePlayerStat(1);
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene5a");
        }
}
