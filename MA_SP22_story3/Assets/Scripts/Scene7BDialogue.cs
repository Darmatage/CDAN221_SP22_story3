using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene7BDialogue : MonoBehaviour {
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
			Char2speech.text = "On the night of Homecoming, your parents force you to have pictures taken. A few minutes soon turn to an hour.";
		}
		else if (primeInt == 3){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "Finally, you arrive at school with an annoyed Rei staring you down.";
		}
		else if (primeInt == 4){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "I'm here! I'm here...";
		}
		else if (primeInt == 5){
			ArtChar1.SetActive(true);
			Char1name.text = "Rei";
			Char1speech.text = "Hmph, took you quite some time. Well, looks like you're ready now.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 6){
			Choice1a.SetActive(true);
			Choice1b.SetActive(true);
			allowSpace = false;
			nextButton.SetActive(false);
		}
		else if (primeInt == 11){
			Char1name.text = "Rei";
			Char1speech.text = "Hm. That's something we'll have to rectify at a later time.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 12){
			Char1name.text = "Rei";
			Char1speech.text = "It wouldn't do for my potential partner to be so uncouth in the ways of their dress.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 13){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Well, what can I say? Comfort over fashion any day of the week.";
		}
		else if (primeInt == 14){
			Char1name.text = "Rei";
			Char1speech.text = "Still, you would be better off without such a crass attitude.";
			Char2name.text = "";
			Char2speech.text = "";
			primeInt = 102;
		}
		else if (primeInt == 51){
			ArtChar1.SetActive(false);
			ArtChar2.SetActive(true);
			Char1name.text = "Rei";
			Char1speech.text = "Oh? Do you happen to have any of said pictures on your person?";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 52){
			allowSpace = false;
			nextButton.SetActive(false);
			Choice1c.SetActive(true);
			Choice1d.SetActive(true);
		}
		else if (primeInt == 101){
			Char1name.text = "Rei";
			Char1speech.text = "Oh? Why so resolute with your answer?";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 102){
			Char1name.text = "Rei";
			Char1speech.text = "No matter. There will be plenty of opportunities throughout the night for us to remember it by.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 103){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Yeesh. You know we're at a dance right?";
		}
		else if (primeInt == 104){
			Char1name.text = "Rei";
			Char1speech.text = "What of it?";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 105){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Do you think you can.. I dunno... loosen up a little?";
		}
		else if (primeInt == 106){
			ArtChar2.SetActive(false);
			ArtChar1.SetActive(true);
			Char1name.text = "Rei";
			Char1speech.text = "Excuse me? A school dance is all the more reason to be perfect and refined.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 107){
			Char1name.text = "Rei";
			Char1speech.text = "Imagine if I'd let you come wearing whatever you pleased.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 108){
			ArtChar2.SetActive(true);
			ArtChar1.SetActive(false);
			Char1name.text = "Rei";
			Char1speech.text = "Thankfully, yours truly had gotten that outfit of yours especially tailored to fit you just right.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 109){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Thanks again for that. I have to wonder though, if we're not here to really let loose and do whatever then...";
		}
		else if (primeInt == 110){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "What's the point?";
		}
		else if (primeInt == 111){
			ArtChar2.SetActive(false);
			ArtChar3.SetActive(true);
			Char1name.text = "Rei";
			Char1speech.text = "...What's the point?";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 112){
			Char1name.text = "Rei";
			Char1speech.text = "The POINT is to look prestine and refined, elegant yet graceful. All without lifting a finger nor toe.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 113){
			Char1name.text = "Rei";
			Char1speech.text = "While these ruffians get, how you say, down and dirty, sweating and dirtying themselves...";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 114){
			Char1name.text = "Rei";
			Char1speech.text = "We shall stand by and watch everyone else make fools of themselves. It's really quite simple.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 115){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Rei, not to rain on your parade or anything but that doesn't sound very fun.";
		}
		else if (primeInt == 116){
			ArtChar3.SetActive(false);
			ArtChar1.SetActive(true);
			Char1name.text = "Rei";
			Char1speech.text = "Please, and what do you know about fun? Remember, I know what's best.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 117){
			ArtChar1.SetActive(false);
			ArtChar2.SetActive(true);
			Char1name.text = "Rei";
			Char1speech.text = "Needn't forget how I enlightened your taste buds by introducting them to the wonders of a gourmet tart.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 118){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Yes, I'll never forget that glorious day of salvation. Though I'd think it would be nice to just give what other people are doing a try?";
		}
		else if (primeInt == 119){
			ArtChar2.SetActive(false);
			ArtChar1.SetActive(true);
			Char1name.text = "Rei";
			Char1speech.text = "Other people's tarts? Are you MAD?";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 120){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "DANCING. I meant dancing. Let's give it a try.";
		}
		else if (primeInt == 121){
			Char1name.text = "Rei";
			Char1speech.text = "Why are we still talking about this? I thought I was clear.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 122){
			allowSpace = false;
			nextButton.SetActive(false);
			Choice1e.SetActive(true);
			Choice1f.SetActive(true);
		}
		else if (primeInt == 151){
			Char1name.text = "Rei";
			Char1speech.text = "Wait, you can't be serious?";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 152){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Well, someone has to show these guys the proper way to dance! I'll just have to start one person at a time.";
			primeInt = 203;
		}
		else if (primeInt == 201){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "We march down onto that dance floor and show everyone how uncivilized they are by dancing like they do.";
		}
		else if (primeInt == 202){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "They'd see how silly we'd look and see the error of their ways. Make sense?";
		}
		else if (primeInt == 203){
			Char1name.text = "Rei";
			Char1speech.text = "Well, I suppose if you put it that way...";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 204){
			ArtChar1.SetActive(false);
			ArtChar2.SetActive(true);
			Char1name.text = "Rei";
			Char1speech.text = "Very well. They will surely see the error of their ways if we demonstrate it ourselves.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 205){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Then here, let's show them how stupid they look yeah?";
		}
		else if (primeInt == 206){
			Char1name.text = "Rei";
			Char1speech.text = "Yes! Together we shall outdance all of them so hard they'll have no choice but to see the error of their ways and see the light!";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 207){
			NextScene1Button.SetActive(true);
		}
}

		public void Choice1aFunct(){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Sorry about that. I'm not exactly used to wearing stuff like this so it took me a while to figure out.";
			Choice1a.SetActive(false);
			Choice1b.SetActive(false);
			allowSpace = true;
			nextButton.SetActive(true);
			primeInt = 10;
		}
		public void Choice1bFunct(){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Sorry, my parents... They were insufferable. Kept wanting to take picture after picture.";
			Choice1a.SetActive(false);
			Choice1b.SetActive(false);
			allowSpace = true;
			nextButton.SetActive(true);
			primeInt = 50;
		}
		public void Choice1cFunct(){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Yes, but you're never going to see them. There's nothing you can say that'll change my mind on that.";
			allowSpace = true;
			nextButton.SetActive(true);
			Choice1c.SetActive(false);
			Choice1d.SetActive(false);
			primeInt = 100;
		}
		public void Choice1dFunct(){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "No I do not. And before you say anything, you are absolutely never going to see them. Ever.";
			Choice1c.SetActive(false);
			Choice1d.SetActive(false);
			allowSpace = true;
			nextButton.SetActive(true);
			primeInt = 100;
		}
		public void Choice1eFunct(){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Well, I guess I'll have to ask some other person to dance with me. Not that you'd mind right?";
			allowSpace = true;
			nextButton.SetActive(true);
			primeInt = 150;
			Choice1e.SetActive(false);
			Choice1f.SetActive(false);
		}
		public void Choice1fFunct(){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Hey, think about it this way.";
			allowSpace = true;
			nextButton.SetActive(true);
			primeInt = 200;
			Choice1e.SetActive(false);
			Choice1f.SetActive(false);
		}
		public void SceneChange1(){
			SceneManager.LoadScene("End_WinRei");
		}
}