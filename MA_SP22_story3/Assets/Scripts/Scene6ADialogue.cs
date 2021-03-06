using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene6ADialogue : MonoBehaviour {
        public int primeInt = 1;
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
		public GameObject ArtChar4;
		//public GameObject ArtCharB1;
		//public GameObject ArtCharB2;
		//public GameObject ArtCharB3;
        public GameObject ArtBG1;
		//public GameObject ArtBG2;
        public GameObject Choice1a;
        public GameObject Choice1b;
		public GameObject Choice1c;
		public GameObject Choice1d;
		public GameObject Choice1e;
		public GameObject Choice1f;
		//public GameObject Choice1g;
		//public GameObject Choice1h;
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
		ArtChar4.SetActive(false);
		//ArtCharB1.SetActive(false);
		//ArtCharB2.SetActive(false);
		//ArtCharB3.SetActive(false);
        ArtBG1.SetActive(true);
		//ArtBG2.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice1c.SetActive(false);
		Choice1d.SetActive(false);
		Choice1e.SetActive(false);
		Choice1f.SetActive(false);
		//Choice1g.SetActive(false);
		//Choice1h.SetActive(false);
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
            Char2speech.text = "Some time later...";
		}
		else if (primeInt == 3){
			ArtChar1.SetActive(true);
			Char1name.text = "";
			Char2name.text = playerName;
			Char1speech.text = "";
			Char2speech.text = "So...";
		}
		else if (primeInt == 4){
			Char1name.text = "Reyes";
            Char1speech.text = "What?";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 5){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Any plans for Homecoming?";
		}
		else if (primeInt == 6){
				Char1name.text = "Reyes";
                Char1speech.text = "You can't be serious. Why would I bother with something like that?";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 7){
			Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "What? I just thought it'd be fun or something.";
		}
		else if (primeInt == 8){
			ArtChar1.SetActive(false);
			ArtChar3.SetActive(true);
				Char1name.text = "Reyes";
                Char1speech.text = "Fun for who exactly?";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 9){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "I guess if you really don't want to go, I could always ask someone else...";
		}
		else if(primeInt == 10){
				Char1name.text = "Reyes";
                Char1speech.text = "...I never said no...";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 11){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "I don't know... You seemed pretty against it.";
		}
		else if (primeInt == 12){
			Char1name.text = "Reyes";
                Char1speech.text = "...fine.";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 13){
			Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "I'm sorry, what was that?";
		}
		else if (primeInt == 14){
			Char1name.text = "Reyes";
                Char1speech.text = "I said I'll go. With you. To Homecoming.";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 15){
			Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Now that wasn't so hard to accept, was it?";
		}
		else if (primeInt == 16){
			ArtChar3.SetActive(false);
			ArtChar2.SetActive(true);
			Char1name.text = "Reyes";
                Char1speech.text = "...as long as it keeps you happy, I guess.";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 17){
			Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Sorry, what was that?";
		}
		else if (primeInt == 18){
			ArtChar2.SetActive(false);
			ArtChar1.SetActive(true);
			Char1name.text = "Reyes";
                Char1speech.text = "Nothing. Just be there by, I don't know, half an hour after the event starts.";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 19){
			Char1name.text = "Reyes";
                Char1speech.text = "Wouldn't want to be caught dead at the event on time.";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 20){
			Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Haha, sure. Whatever you say.";
		}
		else if (primeInt == 21){
			Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "See you later then?";
		}
		else if (primeInt == 22){
			Char1name.text = "Reyes";
                Char1speech.text = "Yeah... See you later.";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 23){
			allowSpace = false;
			nextButton.SetActive(false);
			NextScene1Button.SetActive(true);
		}
}
		public void SceneChange1(){
			SceneManager.LoadScene("Scene7A");
		}
}