using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene7CDialogue : MonoBehaviour {
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
		//public GameObject Choice1e;
		//public GameObject Choice1f;
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
		//Choice1e.SetActive(false);
		//Choice1f.SetActive(false);
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
			Char2speech.text = "At the dance....";
		}
		else if (primeInt == 3){
			ArtChar2.SetActive(true);
			Char1name.text = "Luka";
			Char1speech.text = "We're here! We're really really here!";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 4){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Hahaha, gee. Calm down Luka, it's just a school dance.";
		}
		else if (primeInt == 5){
			Char1name.text = "Luka";
			Char1speech.text = "I knooooow but this is my first time! And even better, my first time being here in one with you!";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 6){
			Char1name.text = "Luka";
			Char1speech.text = "This is the best day of my life!";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 7){
			Choice1a.SetActive(true);
			Choice1b.SetActive(true);
			allowSpace = false;
			nextButton.SetActive(false);
		}
		else if (primeInt == 50){
			Char1name.text = "Luka";
			Char1speech.text = "Oh! How could I forget? Okay, okay. Second best day of my life then.";
			Char2name.text = "";
			Char2speech.text = "";
			primeInt = 102;
		}
		else if (primeInt == 100){
			Char1name.text = "Luka";
			Char1speech.text = "How can it NOT be? Us being together makes it a million times more fun!";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 101){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "I can't argue with you there. You always know how to liven things up with your presence, Luka.";
		}
		else if (primeInt == 102){
			ArtChar2.SetActive(false);
			ArtChar1.SetActive(true);
			Char1name.text = "Luka";
			Char1speech.text = "You... really think so? Haha... Thanks bestie.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 103){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Well I  gotta say, there sure is a lot we could do here?";
		}
		else if (primeInt == 104){
			ArtChar1.SetActive(false);
			ArtChar2.SetActive(true);
			Char1name.text = "Luka";
			Char1speech.text = "What should we do first? Get something to drink? Or something to eat?";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 105){
			Char1name.text = "Luka";
			Char1speech.text = "Take some photos? Or maybe we can-";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 106){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "How about we dance?";
		}
		else if (primeInt == 107){
			ArtChar2.SetActive(false);
			ArtChar1.SetActive(true);
			Char1name.text = "Luka";
			Char1speech.text = "D-dance?";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 108){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Yep.";
		}
		else if (primeInt == 109){
			Char1name.text = "Luka";
			Char1speech.text = "W-with you??";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 110){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Yep.";
		}
		else if (primeInt == 111){
			Char1name.text = "Luka";
			Char1speech.text = "R-really???";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 112){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Hehe, geez. Yes, Luka really. Believe it or not, I wanna dance.";
		}
		else if (primeInt == 113){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "With. You. Period.";
		}
		else if (primeInt == 114){
			ArtChar1.SetActive(false);
			ArtChar3.SetActive(true);
			Char1name.text = "Luka";
			Char1speech.text = "I... I...";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 115){
			ArtChar3.SetActive(false);
			ArtChar2.SetActive(true);
			Char1name.text = "Luka";
			Char1speech.text = "I don't know what to say. I'm trying to fight back tears.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 116){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Aw Luka, it's alright.";
		}
		else if (primeInt == 117){
			Char1name.text = "Luka";
			Char1speech.text = "I'm sorry... It's just... This means so much to me, you know?";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 118){
			Char1name.text = "Luka";
			Char1speech.text = "To dance with the very person who rescued me from a life of loneliness. I'm so grateful.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 119){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "I'm so grateful... Thank you. Thank you so much for keeping me around when everyone else threw me away.";
			Char2speech.text = "";
		}
		else if (primeInt == 120){
			Char1name.text = "Luka";
			Char1speech.text = "Thank you. Thank you bestie.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 121){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "Tears begin to fall from Luka's eyes.";
		}
		else if (primeInt == 122){
			Choice1c.SetActive(true);
			Choice1d.SetActive(false);
			allowSpace = false;
			nextButton.SetActive(false);
		}
		else if (primeInt == 151){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "You know, I'm the one who should be thanking you.";
		}
		else if (primeInt == 152){
			ArtChar2.SetActive(false);
			ArtChar1.SetActive(true);
			Char1name.text = "Luka";
			Char1speech.text = "Huh? W-why thank me?";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 153){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "It's thanks to you that I'm able to get through school as well as I am now.";
		}
		else if (primeInt == 154){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "When things started, I was scared and alone... didn't know anyone or what was in store.";
		}
		else if (primeInt == 155){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "I just wanted to go home. But then I saw you, a familiar face. I thought school would be a drag but being together with you again has been thbe best.";
		}
		else if (primeInt == 156){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "And so, thank you for sticking with me Luka.";
		}
		else if (primeInt == 157){
			ArtChar1.SetActive(false);
			ArtChar2.SetActive(true);
			Char1name.text = "Luka";
			Char1speech.text = "Wow. I-I never thought I did so much for you. Just me being around.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 158){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "playerName";
			Char2speech.text = "You do a lot more than you know. Now let's get to dancing!";
		}
		else if (primeInt == 159){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Everyone else better not be jealous because I got myself the perfect partner.";
		}
		else if (primeInt == 160){
			ArtChar2.SetActive(false);
			ArtChar3.SetActive(true);
			Char1name.text = "Luka";
			Char1speech.text = "W-wait! Who are they? Am I being replaced? Oh no, not again...";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 161){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "It's YOU LUKA! Now, let's go!";
		}
		else if (primeInt == 162){
			ArtChar3.SetActive(false);
			ArtChar1.SetActive(true);
			Char1name.text = "Luka";
			Char1speech.text = "Ohhhh hahaha of course! Let's dance bestie!";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 163){
			NextScene1Button.SetActive(true);
		}
}
		public void Choice1aFunct(){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "You can't really mean that right? What about the day we met?";
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
			Char2speech.text = "Is it really that exhilerating?";
			allowSpace = true;
			nextButton.SetActive(true);
			primeInt = 100;
			Choice1a.SetActive(false);
			Choice1b.SetActive(false);
		}
		public void Choice1cFunct(){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "It's okay Luka. It's okay.";
			allowSpace = true;
			nextButton.SetActive(true);
			Choice1c.SetActive(false);
			Choice1d.SetActive(false);
			primeInt = 150;
		}
		public void Choice1dFunct(){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "There there. No need to cry. I'm not going anywhere.";
			allowSpace = true;
			nextButton.SetActive(true);
			Choice1c.SetActive(false);
			Choice1d.SetActive(false);
			primeInt = 150;
		}
		public void SceneChange1(){
			SceneManager.LoadScene("End_WinLuka");
		}
}