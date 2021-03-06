using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene6CDialogue : MonoBehaviour {
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
		//public GameObject ArtChar4;
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
		//ArtChar4.SetActive(false);
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
			Char2speech.text = "The next day at school...";
		}
		else if (primeInt == 3){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Hey! Luka!";
		}
		else if (primeInt == 4){
			ArtChar2.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Luka";
			Char2speech.text = "Oh, hey " + playerName + "! What's going on?";
		}
		else if (primeInt == 5){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Nothing nothing. Hey, I was wondering if you had a date for Homecoming this Friday?";
		}
		else if (primeInt == 6){
			ArtChar2.SetActive(false);
			ArtChar1.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Luka";
			Char2speech.text = "Honestly, I don't. I planned on staying home and making some more crafts to give you.";
		}
		else if (primeInt == 7){
			Choice1a.SetActive(true);
			Choice1b.SetActive(true);
			allowSpace = false;
			nextButton.SetActive(false);
		}
		else if (primeInt == 51){
			ArtChar2.SetActive(true);
			ArtChar1.SetActive(false);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Luka";
			Char2speech.text = "Of course! Anything for my bestie.";
		}
		else if (primeInt == 52){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Luka";
			Char2speech.text = "But why'd you ask about homecoming?";
			primeInt = 101;
		}
		else if (primeInt == 101){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Luka";
			Char2speech.text = "Huh? What do you mean? I don't understand.";
		}
		else if (primeInt == 102){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "You're going to be my date!";	
		}
		else if (primeInt == 103){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Luka";
			Char2speech.text = "...";
		}
		else if (primeInt == 104){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "?";
		}
		else if (primeInt == 105){
			ArtChar2.SetActive(true);
			ArtChar1.SetActive(false);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Luka";
			Char2speech.text = "...";
		}
		else if (primeInt == 106){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Uhh, you alright Luka?";
		}
		else if (primeInt == 107){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Luka";
			Char2speech.text = "Do.. do you mean it?";
		}
		else if (primeInt == 108){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Of course I mean it. I wouldn't want to go with anyone else. You're my best friend and I would love to go with you.";
		}
		else if (primeInt == 109){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Luka";
			Char2speech.text = "Oh my gosh, I can't. I need to get ready! I don't have anything prepared!";
		}
		else if (primeInt == 110){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "You watch Luka dash out of the hallway.";
		}
		else if (primeInt == 111){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Well, this is going to be exciting.";
		}
		else if (primeInt == 112){
			NextScene1Button.SetActive(true);
		}
}

	public void Choice1aFunt(){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Oh, that's... actually really sweet. Thank you.";
			allowSpace = true;
			nextButton.SetActive(true);
			primeInt = 50;
			Choice1a.SetActive(false);
			Choice1b.SetActive(false);
	}
	public void Choice1bFunct(){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Forget about the bracelets! C'mon! Let's enjoy ourselves.";
			allowSpace = true;
			nextButton.SetActive(true);
			primeInt = 100;
			Choice1a.SetActive(false);
			Choice1b.SetActive(false);
	}
	public void SceneChange1(){
		SceneManager.LoadScene("Scene7C");
	}
}