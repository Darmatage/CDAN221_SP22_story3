using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene7ADialogue : MonoBehaviour {
        public int primeInt = 1;
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
		public Text Char3name;
		public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1;
		public GameObject ArtChar2;
		public GameObject ArtChar3;
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
		public GameObject NextScene2Button;
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
		NextScene2Button.SetActive(false);
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
public void talking(){         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1){
                // AudioSource.Play();
        }
		else if (primeInt == 2) {
			DialogueDisplay.SetActive(true);
			ArtChar3.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "Reyes";
			Char3speech.text = "Ugh, what a drag. Being here dressed like this.";
		}
		else if (primeInt == 3){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "Reyes";
			Char3speech.text = "How'd I even get talked into doing something like this...";
		}
		else if (primeInt == 4){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "It was the night of Homecoming and Reyes was side-eyeing anyone that got too close.";
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 5){
			Choice1a.SetActive(true);
			Choice1b.SetActive(true);
			allowSpace = false;
			nextButton.SetActive(false);
		}
		else if (primeInt == 50){
			Char1name.text = "";
            Char1speech.text = "";
			Char2name.text = "";
            Char2speech.text = "";
			Char3name.text = "Reyes";
			Char3speech.text = "And remind me why I agreed to be here upon your request?";
		}
		else if (primeInt == 51){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Because... you actually care?";
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 52){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "Reyes";
			Char3speech.text = "W-whatever. I mean, as if!";
		}
		else if (primeInt == 53){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "Reyes";
			Char3speech.text = "I just remembered there was food here and figured I might as well take advantage of the schools' hospitality. Got that?";
			primeInt = 100;
		}
		else if (primeInt == 100){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "Reyes";
			Char3speech.text = "Well- You know what? Whatever. I'm already here anyway.";
		}
		else if (primeInt == 101){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Oh sure. But you know... you can drop the act.";
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 102){
			ArtChar3.SetActive(false);
			ArtChar1.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "Reyes";
			Char3speech.text = "What act? This ain't no act.";
		}	
		else if (primeInt == 103){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "At first maybe not. But I know you well enough to know you still have a heart in there somewhere.";
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 104){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "Reyes";
			Char3speech.text = "Hmph. Oh yeah? Well. Ugh.";
		}
		else if (primeInt == 105){
			Choice1c.SetActive(true);
			Choice1d.SetActive(true);
			allowSpace = false;
			nextButton.SetActive(false);
		}
		else if (primeInt == 151){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "They said it might be good to participate in non-school work related activities once in a while, hoping it'd curb my disobedience or something.";
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 152){
			ArtChar2.SetActive(true);
			ArtChar1.SetActive(false);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "Reyes";
			Char3speech.text = "Well? Has his experience curbed your disobedience?";
		}
		else if (primeInt == 153){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "What do you think?";
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 154){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "Reyes";
			Char3speech.text = "Yes?";
		}
		else if (primeInt == 155){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "No. Not it hasn't, Reyes.";
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 156){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "Reyes";
			Char3speech.text = "Ay, got it on the first try.";
		}
		else if (primeInt == 157){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "You think you're so smooth huh? Well, a new song's coming up. Why don't you show these fools your moves?";
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 158){
			ArtChar2.SetActive(false);
			ArtChar1.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "Reyes";
			Char3speech.text = "The real fool is clearly you if you think I'm doing that.";
		}
		else if (primeInt == 159){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "For the monarch of apathy, you seem to have a lot of pride.";
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 160){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "Reyes";
			Char3speech.text = "And for someone who is supposedly in the high honor roll, you seem to have poor judgement.";
		}
		else if (primeInt == 161){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Please, spare me. You know my judgement's always poor considering how often I skip school with you.";
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 162){
			ArtChar2.SetActive(true);
			ArtChar1.SetActive(false);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "Reyes";
			Char3speech.text = "Fair, fair.";
		}
		else if (primeInt == 163){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Now, are you going to join me on the dance floor or am I going to have to find someone else to dance with?";
			Char3name.text = "";
			Char3speech.text = "";
		}
		else if (primeInt == 164){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "Reyes";
			Char3speech.text = "Wait, before you go running off.";
		}
		else if (primeInt == 165){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "Reyss";
			Char3speech.text = "How about we ditch this joint? I know a better spot we can spend the rest of the night.";
		}
		else if(primeInt == 166){
			Choice1e.SetActive(true);
			Choice1f.SetActive(true);
			allowSpace = false;
			nextButton.SetActive(false);
		}
		else if (primeInt == 200){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "Reyes";
			Char3speech.text = "Well, since you're here... I guess not.";
		}
		else if (primeInt == 201){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Now c'mon. Let's head to the dance floor.";
			Char3name.text = "";
			Char3speech.text = "";
			primeInt = 157;
		}
		else if (primeInt == 301){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "Reyes";
			Char3speech.text = "Trust me, you'll love it. Have I ever lied to you?";
		}
		else if (primeInt == 302){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "I guess not...";
			Char3name.text = "";
			Char3speech.text = "";
			primeInt = 350;
		}
		else if (primeInt == 351){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "";
			Char3name.text = "Reyes";
			Char3speech.text = "Perfect. C'mon. This way.";
		}
		else if (primeInt == 352){
			NextScene1Button.SetActive(true);
		}
		
}

		public void Choice1aFunct(){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "playerName";
			Char2speech.text = "Well, how else were you going to spend your Friday night?";
			Char3name.text = "";
			Char3speech.text = "";
			primeInt = 49;
			Choice1a.SetActive(false);
			Choice1b.SetActive(false);
			allowSpace = true;
			nextButton.SetActive(true);
		}
		
		public void Choice1bFunct (){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Simple, because I asked you to come.";
				Char3name.text = "";
				Char3speech.text = "";
				primeInt = 99;
				Choice1a.SetActive(false);
				Choice1b.SetActive(false);
				allowSpace = true;
				nextButton.SetActive(true);
		}
		
		public void Choice1cFunt(){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "I don't want to be here as much as you. But my parents made me.";
			Char3name.text = "";
			Char3speech.text = "";
			allowSpace = true;
			nextButton.SetActive(true);
			primeInt = 150;
			Choice1c.SetActive(false);
			Choice1d.SetActive(false);
		}
		
		public void Choice1dFunct(){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Really though, it's not that bad is it?";
			Char3name.text = "";
			Char3speech.text = "";
			allowSpace = true;
			nextButton.SetActive(true);
			primeInt = 200;
			Choice1c.SetActive(false);
			Choice1d.SetActive(false);
		}
		
		public void Choice1eFunct(){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "You know what? Sure. What's the worst that could happen?";
			Char3name.text = "";
			Char3speech.text = "";
			allowSpace = true;
			nextButton.SetActive(true);
			primeInt = 350;
			Choice1e.SetActive(false);
			Choice1f.SetActive(false);
			}
		
		public void Choice1fFunct(){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Are you sure? I don't know...";
			Char3name.text = "";
			Char3speech.text = "";
			allowSpace = true;
			nextButton.SetActive(true);
			primeInt = 300;
			Choice1e.SetActive(false);
			Choice1f.SetActive(false);
		}
		
		public void SceneChange1(){
			SceneManager.LoadScene("End_WinReyes");
		}
}