using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene6ABad : MonoBehaviour {
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
		public GameObject ArtBG2;
		public GameObject ArtBG3;
		public GameObject ArtBG4;
        public GameObject Choice1a;
        public GameObject Choice1b;
		public GameObject Choice1c;
		public GameObject Choice1d;
		//public GameObject Choice1e;
		//public GameObject Choice1f;
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
		ArtChar4.SetActive(false);
		//ArtCharB1.SetActive(false);
		//ArtCharB2.SetActive(false);
		//ArtCharB3.SetActive(false);
        ArtBG1.SetActive(true);
		ArtBG2.SetActive(false);
		ArtBG3.SetActive(false);
		ArtBG4.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice1c.SetActive(false);
		Choice1d.SetActive(false);
		//Choice1e.SetActive(false);
		//Choice1f.SetActive(false);
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
            Char2speech.text = "The next day...";
		}
		else if (primeInt == 3){
			Char1name.text = "";
			Char2name.text = playerName;
			Char1speech.text = "";
			Char2speech.text = "He's not in class today...";
		}
		else if (primeInt == 4) {
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Wonder where he's at?";
		}
		else if (primeInt == 5) {
			Choice1a.SetActive(true);
			Choice1b.SetActive(true);
			allowSpace = false;
			nextButton.SetActive(false);
		}
		else if (primeInt == 101){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "Wonder if he's at the spot where I first found him...";	
		}
		else if (primeInt == 102) {
			ArtBG2.SetActive(false);
			ArtBG3.SetActive(false);
			ArtBG4.SetActive(true);
			ArtChar3.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Ah, there he is.";
		}
		else if (primeInt == 103){
			ArtChar3.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Hey Reyes!";
		}
		else if (primeInt == 104){
			Char1name.text = "Reyes";
			Char1speech.text = "Ah, look who decided to show their face.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 105){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Huh? What do you mean?";
		}
		else if (primeInt == 106){
			Char1name.text = "Reyes";
			Char1speech.text = "Don't play dumb. Especially after how you've acted.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 107){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "I really don't know what you mean. You're acting really distant.";
		}
		else if (primeInt == 108){
			Char1name.text = "Reyes";
			Char1speech.text = "I'm the same as always, no idea what you're talking about.";
			Char1name.text = "";
			Char1speech.text = "";
		}
		else if (primeInt == 109){
			    Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "If you've got a problem, then say it.";
		}
		else if (primeInt == 110){
				Char1name.text = "Reyes";
				Char1speech.text = "I don't have a problem. Tch. Why should I care?";
				Char2name.text = "";
				Char2speech.text = "";
		}
		else if (primeInt == 111){
			    Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
		Char2speech.text = "Will you quit it with the whole 'I don't care about anything' act?";
		}
		else if (primeInt == 112){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "I've known you well enough by now to know you do care about things.";
		}
		else if (primeInt == 113){
			ArtChar3.SetActive(false);
			ArtChar4.SetActive(true);
			Char1name.text = "Reyes";
			Char1speech.text = "You? Know ME? Now that's funny.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 114){
			Char1name.text = "Reyes";
			Char1speech.text = "I think you got the wrong idea pal, you don't know a thing about me.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 115){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Are you saying all this time I've been skipping school to hang with you, I don't know you?";
		}
		else if (primeInt == 116){
				ArtChar4.SetActive(false);
				ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "You've shown me a different side of you.";
		}
		else if (primeInt == 117){
			    Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "I know underneath that facade is someone who cares.";
		}
		else if (primeInt == 118){
			    Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Why can' you trust me enough to just be honest?";
		}
		else if (primeInt == 119){
				ArtChar3.SetActive(false);
				ArtChar4.SetActive(true);
			    Char1name.text = "Reyes";
                Char1speech.text = "You want honest? Fine.";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 120){
			   Char1name.text = "Reyes";
                Char1speech.text = "Honestly speaking, if you knew me at all, you'd know I rarely go out of my way for others.";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 121){
			    Char1name.text = "Reyes";
                Char1speech.text = "I made an exception FOR YOU. I got those gifts and flowers FOR YOU.";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 122){
				ArtChar4.SetActive(false);
				ArtChar3.SetActive(true);
			    Char1name.text = "Reyes";
                Char1speech.text = "For once, I was acting selfless for someone else I thought I might've actually...";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 123){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "What?";
		}
		else if (primeInt == 124){
				ArtChar3.SetActive(false);
				ArtChar1.SetActive(true);
				Char1name.text = "Reyes";
                Char1speech.text = "You know what? Forget it.";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 125){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "No, we're not dropping this. You always do this.";
		}
		else if (primeInt == 126){
				Char1name.text = "Reyes";
                Char1speech.text = "Like I said, there's nothing more to say.";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 127){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Shut up.";
		}
		else if (primeInt == 128){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "I'm sick and tired of you brushing things off like they don't matter.";
		}
		else if (primeInt == 129){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Just tell me-";
		}
		else if (primeInt == 130){
				ArtChar1.SetActive(false);
				ArtChar4.SetActive(true);
				Char1name.text = "Reyes";
                Char1speech.text = "There's nothing. To. Talk. About.";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 131){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "All this over what? A few things that pissed you off? Just move on dude.";
		}
		else if (primeInt == 132){
				Char1name.text = "Reyes";
                Char1speech.text = "Yeah, just a few things. THINGS that I thought would make you happy.";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 133){
				Char1name.text = "Reyes";
                Char1speech.text = "DUMB things that I wasted my time on.";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 134){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Dude! How was I supposed to know? You didn't give me a note or anything.";
		}
		else if (primeInt == 135){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "You never tell me. You always make me assume things. It's honestly your fault for being so stubborn.";
		}
		else if (primeInt == 136){
				Char1name.text = "Reyes";
                Char1speech.text = "Heh, my fault? Sure. Tch, that's the last time I go outta my way for someone.";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 137){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Whatever...";
		}
		else if (primeInt == 138){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "What are we going to do now?";
		}
		else if (primeInt == 139){
				Char1name.text = "Reyes";
                Char1speech.text = "'We' aren't going to anything.";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 140){
				Char1name.text = "Reyes";
                Char1speech.text = "I'm out. I don't care what you do.";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 141){
				ArtChar4.SetActive(false);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "You watch as Reyes leaves without another word.";
		}
		else if (primeInt == 142){
				allowSpace = false;
				nextButton.SetActive(false);
				Choice1c.SetActive(true);
				Choice1d.SetActive(true);
		}
		else if (primeInt == 201){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Reyes! Wait!";
		}
		else if (primeInt == 202){
				ArtChar4.SetActive(true);
				Char1name.text = "Reyes";
                Char1speech.text = "What. Do. You. Want?";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 203){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Alright, look. I'm sorry.";
		}
		else if (primeInt == 204){
				ArtChar4.SetActive(false);
				ArtChar1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "I shouldn't have lashed out at you like that. Nor should I have been an ass to you.";
		}
		else if (primeInt == 205){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Things are still new for me. I'm still getting adjusted to everything here and...";
		}
		else if (primeInt == 206){
			Char1name.text = "Reyes";
                Char1speech.text = "And..?";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 207){
			Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "I freaked out, okay? It's not like me to get all cozy with someone.";
		}
		else if (primeInt == 208){
			Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "I usually stuck to myself and don't let others in. Unless they weasel their way through, I just went on with life.";
		}
		else if (primeInt == 209){
			ArtChar3.SetActive(true);
			ArtChar1.SetActive(false);
			Char1name.text = "Reyes";
                Char1speech.text = "So what? You think this will magically make things better between us?";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 210){
			Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Can you just let me finish?";
		}
		else if (primeInt == 211){
			Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Can you give me another chance? So I can properly make it up to you?";
		}
		else if (primeInt == 212){
			Char1name.text = "Reyes";
                Char1speech.text = "Now how do you plan on doing that?";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 213){
			Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Go to Homecoming with me.";
		}
		else if (primeInt == 214){
				ArtChar3.SetActive(false);
				ArtChar1.SetActive(true);
			Char1name.text = "Reyes";
                Char1speech.text = "No.";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 215){
			Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Just one more chance. If it falls through, I'll never bother you again.";
		}
		else if (primeInt == 216){
			Char1name.text = "Reyes";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 217){
			Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "...";
		}
		else if (primeInt == 218){
			Char1name.text = "Reyes";
                Char1speech.text = "Just this one last chance, got it?";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 219){
			Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Great! You won't regret it.";
		}
		else if (primeInt == 220){
			Char1name.text = "Reyes";
                Char1speech.text = "I better not.";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 221){
			Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "They turn away and continue their exit.";
		}
		else if (primeInt == 222){
			NextScene1Button.SetActive(true);
		}
		else if (primeInt == 251){
			NextScene2Button.SetActive(true);
		}
}
	
		public void Choice1aFunct(){
			ArtBG1.SetActive(false);
			ArtBG2.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Not here...";
			primeInt = 100;
			Choice1a.SetActive(false);
			Choice1b.SetActive(false);
			allowSpace = true;
			nextButton.SetActive(true);
		}
		public void Choice1bFunct(){
			ArtBG1.SetActive(false);
			ArtBG3.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Not here...";
			primeInt = 100;
			Choice1a.SetActive(false);
			Choice1b.SetActive(false);
			allowSpace = true;
			nextButton.SetActive(true);
		}
		public void Choice1cFunct(){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Maybe I overreacted. I should go find him.";
			primeInt = 200;
			Choice1c.SetActive(false);
			Choice1d.SetActive(false);
			allowSpace = true;
			nextButton.SetActive(true);
		}
		public void Choice1dFunct(){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "Whatever man. He can keep to himself if he wants. I'm not going to bother.";
			primeInt = 250;
			Choice1c.SetActive(false);
			Choice1d.SetActive(false);
			allowSpace = true;
			nextButton.SetActive(true);
		}
		public void SceneChange1(){
			SceneManager.LoadScene("Scene7A");
		}
		public void SceneChange2(){
			SceneManager.LoadScene("End_LoseReyes");
		}
}