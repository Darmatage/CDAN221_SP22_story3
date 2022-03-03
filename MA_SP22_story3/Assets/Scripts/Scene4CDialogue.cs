using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene4CDialogue : MonoBehaviour {
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
		public GameObject ArtCharB1;
		public GameObject ArtCharB2;
		public GameObject ArtCharB3;
        public GameObject ArtBG1;
		public GameObject ArtBG2;
        public GameObject Choice1a;
        public GameObject Choice1b;
		public GameObject Choice1c;
		public GameObject Choice1d;
		public GameObject Choice1e;
		public GameObject Choice1f;
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
		ArtCharB1.SetActive(false);
		ArtCharB2.SetActive(false);
		ArtCharB3.SetActive(false);
        ArtBG1.SetActive(true);
		ArtBG2.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice1c.SetActive(false);
		Choice1d.SetActive(false);
		Choice1e.SetActive(false);
		Choice1f.SetActive(false);
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
                Char2speech.text = "You enter the classroom, eyes glancing your way. As you take a seat at your desk, there is a small bouquet of sunflowers.";
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
				ArtCharB1.SetActive(true);
				Char1name.text = "Mrs. Kane";
				Char1speech.text = "Alright class. Please turn to page 25 of your textbook.";
				Char2name.text = "";
				Char2speech.text = "";
		}
		else if (primeInt == 202){
				ArtCharB1.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "To your left, You see Luka bouncing their leg in excitement. You briefly lock eyes, making them beam.";
        }
		else if (primeInt == 203){
				ArtCharB2.SetActive(true);
				Char1name.text = "Mrs. Kane";
				Char1speech.text = "Luka, could you answer question number 4?";
				Char2name.text = "";
				Char2speech.text = "";
		}
		else if (primeInt == 204){
				ArtCharB2.SetActive(false);
				ArtChar2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
				Char2speech.text = "Luka nods excitedly, jumping onto their feet.";
        }
		else if (primeInt == 205){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Luka";
				Char2speech.text = "The mitochondria is the powerhouse of the cell!";
        }
		else if (primeInt == 206){
				ArtChar2.SetActive(false);
				ArtCharB2.SetActive(true);
				Char1name.text = "Mrs. Kane";
                Char1speech.text = "Excellent work, Luka.";
                Char2name.text = "";
				Char2speech.text = "";
		}
	else if (primeInt == 207){
				ArtCharB2.SetActive(false);
				Char1name.text = "";
				Char1speech.text = "Luka cheers to themself before sitting back down. They lean over.";
	}
		else if (primeInt == 208){
				ArtChar2.SetActive(true);
				Char1name.text = "Luka";
                Char1speech.text = "Did you see that, " + playerName + "? I got the question right!";
                Char2name.text = "";
				Char2speech.text = "";
		}
		
		else if (primeInt == 209){
				Choice1e.SetActive(true); // function Choice1aFunct()
                Choice1f.SetActive(true); // function Choice1bFunct()
		}
		
		else if (primeInt == 209){
				Choice1e.SetActive(true); // function Choice1aFunct()
                Choice1f.SetActive(true); // function Choice1bFunct()
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
				ArtChar2.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
				Char2speech.text = "After class, Luka gives you a grin as they pull you into a hug.";
}
		else if (primeInt == 301){
				ArtChar2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Luka";
				Char2speech.text = "Look at you! It looks so pretty! I hope you like it! I spent all night on it!";
		}
		
		else if (primeInt == 302){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
				Char2speech.text = "Thanks a bunch. It looks really good! Reminds me of the one you made for me years ago.";
		}
		else if (primeInt == 303){
				ArtChar1.SetActive(false);
				ArtChar2.SetActive(true);
				Char1name.text = "Luka";
                Char1speech.text = "Of course! I modeled it after it! You still have the old one, right? RIGHT?";
                Char2name.text = "";
				Char2speech.text = "";
		}
		else if (primeInt == 304){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
				Char2speech.text = "Yeah! Of course I kept it.";
		}
		else if (primeInt == 305){
				ArtChar2.SetActive(false);
				ArtChar1.SetActive(true);
				Char1name.text = "Luka";
                Char1speech.text = "Then you can have one on each wrist! We always be together!";
                Char2name.text = "";
				Char2speech.text = "";
		}
		else if (primeInt == 306){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
				Char2speech.text = "Sure sure.";
		}
		else if (primeInt == 307){
			ArtChar2.SetActive(true);
				ArtChar1.SetActive(false);
				Char1name.text = "Luka";
                Char1speech.text = "Come on! The sun's still out, let's hang out like we used to!";
                Char2name.text = "";
				Char2speech.text = "";
		}
		else if (primeInt == 308){
				ArtChar2.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "Luka continues to smile before taking your hand as they lead you out the classroom.";
                Char2name.text = "";
				Char2speech.text = "";
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
		public void Choice1eFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "You give him a shrug.";
                primeInt = 299;
                Choice1e.SetActive(false);
                Choice1f.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
				gameHandler.UpdatePlayerStat(-1);
        }
		public void Choice1fFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Good job, Luka! That was awesome!";
                primeInt = 299;
                Choice1e.SetActive(false);
                Choice1f.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
				gameHandler.UpdatePlayerStat(1);
		}

        public void SceneChange1(){
               SceneManager.LoadScene("Scene5c");
        }
}
