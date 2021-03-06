using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene6BDialogue : MonoBehaviour {
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
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "The next day...";
		}
		else if (primeInt == 3){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Man, I'm exhausted. Can't believe Rei kept me shopping around for hours.";
		}
		else if (primeInt == 4){
			ArtChar1.SetActive(true);
			Char1name.text = "Rei";
			Char1speech.text = "Was that my name that I just heard coming from you?";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 5){
			Choice1a.SetActive(true);
			Choice1b.SetActive(true);
			allowSpace = false;
			nextButton.SetActive(false);
		}
		else if (primeInt == 51){
			ArtChar3.SetActive(true);
			ArtChar1.SetActive(false);
			Char1name.text = "Rei";
			Char1speech.text = "Is that so...";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 52){
			ArtChar3.SetActive(false);
			ArtChar1.SetActive(true);
			Char1name.text = "Rei";
			Char1speech.text = "Regardless, it seems I have one thing that I've neglected these past few days.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 53){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Oh no, what is it?";
		}
		else if (primeInt == 54){
			ArtChar1.SetActive(false);
			ArtChar3.SetActive(true);
			Char1name.text = "Rei";
			Char1speech.text = "Why do you sound so hesitant? I haven't even said it yet.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 55){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Fine. What is it?";
		}
		else if (primeInt == 56){
			ArtChar3.SetActive(false);
			ArtChar2.SetActive(true);
			Char1name.text = "Rei";
			Char1speech.text = "You will be attending the Homecoming dance with me this coming Friday.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 57){
			Choice1c.SetActive(true);
			Choice1d.SetActive(true);
			allowSpace = false;
			nextButton.SetActive(false);
		}
		else if (primeInt == 101){
			ArtChar1.SetActive(true);
			ArtChar2.SetActive(false);
			Char1name.text = "Rei";
			Char1speech.text = "Nonsense. I distinctly remember you complaining that you had nothing to do this coming weekend.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 102){
			Char1name.text = "Rei";
			Char1speech.text = "Of course if you did have something planned, you would simply have to cancel it.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 103){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Why?";
		}
		else if (primeInt == 104){
			Char1name.text = "Rei";
			Char1speech.text = "Well, you are the only one that I would take to this event. Anyone else would be subpar.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 105){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Gee, ever the romantic.";
		}
		else if (primeInt == 106){
			ArtChar1.SetActive(false);
			ArtChar2.SetActive(true);
			Char1name.text = "Rei";
			Char1speech.text = "Of course I am. I'm perfect, remember?";
			Char2name.text = "";
			Char2speech.text = "";
			primeInt = 153;
		}
		else if (primeInt == 151){
			Char1name.text = "Rei";
			Char1speech.text = "Splendid! The clothes we bought the other day was intended to be your attire for that evening.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 152){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Really? I just thought you wanted me to dress nicer in general.";
		}
		else if (primeInt == 153){
			Char1name.text = "Rei";
			Char1speech.text = "Well, of course. But we all have to start somewhere and this event is the perfect occasion for it.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 154){
			Char1name.text = "Rei";
			Char1speech.text = "In any case, there are some preparations that need to be done. I will see you at exactly 7PM sharp. Is that understood?";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 155){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Sure. I'll see you then.";
		}
		else if (primeInt == 156){
			NextScene1Button.SetActive(true);
		}
}
		public void Choice1aFunct(){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "What was that? I didn't hear you?";
			allowSpace = true;
			nextButton.SetActive(true);
			Choice1a.SetActive(false);
			Choice1b.SetActive(false);
			primeInt = 50;
		}
		public void Choice1bFunct(){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "I was just thinking to myself.";
			allowSpace = true;
			nextButton.SetActive(true);
			Choice1a.SetActive(false);
			Choice1b.SetActive(false);
			primeInt = 50;
		}
		public void Choice1cFunct(){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Sure, I don't have anything going on that night.";
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
			Char2speech.text = "No, I think I have something to do on that day.";
			allowSpace = true;
			nextButton.SetActive(true);
			Choice1c.SetActive(false);
			Choice1d.SetActive(false);
			primeInt = 100;
		}
		public void SceneChange1(){
			SceneManager.LoadScene("Scene7B");
		}
}