using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene6BBad : MonoBehaviour {
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
		//public GameObject ArtBG3;
		//public GameObject ArtBG4;
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
		//ArtBG2.SetActive(false);
		//ArtBG3.SetActive(false);
		//ArtBG4.SetActive(false);
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
public void talking(){
	    primeInt = primeInt + 1;
        if (primeInt == 1){
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
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "You wait at the entrance of the classroom, where Rei would usually greet you.";
		}
		else if (primeInt == 4){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "However, they're nowhere to be seen.";
		}
		else if (primeInt == 5){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "It isn't like them to be late. Wonder where they are.";
		}
		else if (primeInt == 6){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "In the distance, you see them walking towards you.";
		}
		else if (primeInt == 7){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "Ah, there he is. I see Rei.";
}
		else if (primeInt == 8){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "Hey! Rei!";
		}
		else if (primeInt == 9){
			ArtChar1.SetActive(true);
			Char1name.text = "Rei";
            Char1speech.text = "...";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 10){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "Hello..? I'm right here-";
		}
		else if (primeInt == 11){
			Char1name.text = "Rei";
            Char1speech.text = "I'm sorry, do I know you?";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 12){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "Huh?";
		}
		else if (primeInt == 13){
			Char1name.text = "Rei";
            Char1speech.text = "If you'll excuse me, I'm busy. Now run along.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 14){
			Choice1a.SetActive(true);
			Choice1b.SetActive(true);
			allowSpace = false;
			nextButton.SetActive(false);
		}
		else if (primeInt == 101){
			Char1name.text = "Rei";
            Char1speech.text = "I don't have the slightest clue on who you are.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 102){
			Char1name.text = "Rei";
            Char1speech.text = "I have never seen you before in my life. Now good day.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 103){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "Are you serious?";
		}
		else if (primeInt == 104){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "All that time I've been following you, doing what you say and now you suddenly don't know who I am?";
		}
		else if (primeInt == 105){
			ArtChar4.SetActive(true);
			ArtChar1.SetActive(false);
			Char1name.text = "Rei";
            Char1speech.text = "Now this is just sad. Can't you take a hint?";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 106){
			Char1name.text = "Rei";
            Char1speech.text = "We're DONE. You're nothing to me.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 107){
			Char1name.text = "Rei";
            Char1speech.text = "You've taken your chance at perfection and ruined it.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 108){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "You've been obsessed with 'perfection'. What is that even supposed to mean?";
		}
		else if (primeInt == 109){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "No one's perfect.";
		}
		else if (primeInt == 110){
			Char1name.text = "Rei";
			Char1speech.text = "Perfection is achieveable by those that put in the proper effort.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 111){
			Char1name.text = "Rei";
			Char1speech.text = "You had one task, one simple job even a chimp could do.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 112){
			Char1name.text = "Rei";
			Char1speech.text = "All you had to do was be silent and abide by what I  said.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 113){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "I've BEEN doing everything you asked of me.";
		}
		else if (primeInt == 114){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Everything you've asked of me, I've done it without complaint.";
		}
		else if (primeInt == 115){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "But honestly, you can't expect me to listen to you all the time.";
		}
		else if (primeInt == 116){
			ArtChar4.SetActive(false);
			ArtChar3.SetActive(true);
			Char1name.text = "Rei";
			Char1speech.text = "Ridiculous. The 'I'm my own person and I can make my own decisions' nonsense.";
			Char2name.text = "";
			Char2speech.text = "";
		} 
		else if (primeInt == 117){
			Char1name.text = "Rei";
			Char1speech.text = "Oh how many times I've heard that line.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 118){
			Char1name.text = "Rei";
			Char1speech.text = "At some point, you all say the exact same thing, word for word.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 119){
			ArtChar3.SetActive(false);
			ArtChar1.SetActive(true);
			Char1name.text = "Rei";
			Char1speech.text = "Pitiful really. Imagine all the correct answers and you decide to choose all the wrong ones.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 120){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "They're only wrong to you.";
		}
		else if (primeInt == 121){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "Not everyone is cookie cutter perfect like you want them to be.";
		}
		else if (primeInt == 122){
			ArtChar4.SetActive(true);
			ArtChar1.SetActive(false);
			Char1name.text = "Rei";
            Char1speech.text = "Everyone CAN be as perfect as I believe they can be. If only they'd just do as I say.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 123){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "What about freedom of choice?";
		}
		else if (primeInt == 124){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "You can't expect me to live my life obediently doing whatever you say.";
		}
		else if (primeInt == 125){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "I want to eat things I like, even if they aren't the best for me. Like a donut every now and then.";
		}
		else if (primeInt == 126){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "I want to do things, go places I want to go. You alone can't just dictate my life.";
		}
		else if (primeInt == 127){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "I'm my own person.";
		}
		else if (primeInt == 128){
			ArtChar4.SetActive(false);
			ArtChar1.SetActive(true);
			Char1name.text = "Rei";
            Char1speech.text = "...And here I thought you were just the person I was looking for.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 129){
			ArtChar1.SetActive(false);
			ArtChar3.SetActive(true);
			Char1name.text = "Rei";
            Char1speech.text = "Yet again, I was mistaken.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 130){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "If you saw me and thought I'd make a great doll for you then yes, you were.";
		}
		else if (primeInt == 131){
			Char1name.text = "Rei";
            Char1speech.text = "Not everyone is blessed with the intellect I possess, nor the wealth to live in the best quality life like I do.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 132){
			Char1name.text = "Rei";
            Char1speech.text = "However, I have the means. The answers... I can make people's lives btter.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 133){
			ArtChar3.SetActive(false);
			ArtChar4.SetActive(true);
			Char1name.text = "Rei";
            Char1speech.text = "It's so frustrating seeing a new face, having hope that maybe, just maybe they'd be someone who'd listen to reason.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 134){
			Char1name.text = "Rei";
            Char1speech.text = "Only to be yet again disapppointed when they rather live a life making poor choices for themselves instead of under my loving care.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 135){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "I'm sorry Rei, but I don't think I can just blindly do as you ask.";
		}
		else if (primeInt == 136){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "Look, I appreciate everything you've been doing for me.";
		}
		else if (primeInt == 137){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "The good food, the gifts. You never really had to go out of your way but you did.";
		}
		else if (primeInt == 138){
			ArtChar4.SetActive(false);
			ArtChar3.SetActive(true);
			Char1name.text = "Rei";
            Char1speech.text = "Hmph. If you were sorry, you wouldn't have acted on your own as you did.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 139){
			Char1name.text = "Rei";
            Char1speech.text = "That was your first, last, and biggest mistake.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 140){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "That's the thing, Rei!";
		}
		else if (primeInt == 141){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "I'm HUMAN. I make mistakes. We aren't perfect-";
		}
		else if (primeInt == 142){
			ArtChar4.SetActive(true);
			ArtChar3.SetActive(false);
			Char1name.text = "Rei";
            Char1speech.text = "YOU aren't perfect.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 143){
			Char1name.text = "Rei";
            Char1speech.text = "As I've told you before, you are nothing to me if you can't live up to my expectations.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 144){
			Char1name.text = "Rei";
            Char1speech.text = "Enjoy living your poor life blindly being ruled by your personal wants and desires.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 145){
			ArtChar3.SetActive(true);
			ArtChar4.SetActive(false);
			Char1name.text = "Rei";
            Char1speech.text = "A true peasant. Can't even appreciate the opportunity of a status change, pitiful.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 146){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "Rei...";
		}
		else if (primeInt == 147){
			ArtChar3.SetActive(false);
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "You watch helplessly as they move past you towards their seat.";
		}
		else if (primeInt == 148){
			allowSpace = false;
			nextButton.SetActive(false);
			Choice1c.SetActive(true);
			Choice1d.SetActive(true);
		}
		else if (primeInt == 201){
			Char1name.text = "Rei";
            Char1speech.text = "Humor? I haven't a clue as to what you mean.";
            Char2name.text = "";
            Char2speech.text = "";
			primeInt = 101;
		}
		else if (primeInt == 301){
			NextScene1Button.SetActive(true);
		}
		else if (primeInt == 401){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Rei! Wait!";
		}
		else if (primeInt == 402){
			ArtChar4.SetActive(true);
			Char1name.text = "Rei";
			Char1speech.text = "You must be daft or an entirely new breed of dull. What about these instructions do you not understand?";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 403){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Come to Homecoming with me. Please.";
		}
		else if (primeInt == 404){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "I know I don't deserve another chance but...";
		}
		else if (primeInt == 405){
			ArtChar4.SetActive(false);
			ArtChar3.SetActive(true);
			Char1name.text = "Rei";
			Char1speech.text = "But?";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 406){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "I'll prove it. I'll prove that I don't have to be perfect to be with you.";
		}
		else if (primeInt == 407){
			Char1name.text = "Rei";
			Char1speech.text = "And if you manage to fail?";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 408){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Then you won't have to deal with me ever again. I'll disappear from your sights.";
		}
		else if (primeInt == 409){
			Char1name.text = "Rei";
			Char1speech.text = "Yes. 'Disappear'. Alright, I'll humor you this once.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 410){
			ArtChar3.SetActive(false);
			ArtChar1.SetActive(true);
			Char1name.text = "Rei";
			Char1speech.text = "But if I find that I am at all displeased, you will face the consequences.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 411){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Okay. I'll see you Friday then.";
		}
		else if (primeInt == 412){
			Char1name.text = "Rei";
			Char1speech.text = "Do show up on time.";
			Char2name.text = "";
			Char2speech.text = "";
		}
		else if (primeInt == 413){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "They continue their way towards their seat.";
		}
		else if (primeInt == 414){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Only one way to fix things now...";
		}
		else if (primeInt == 415){
			NextScene2Button.SetActive(true);
		}
}

		public void Choice1aFunct(){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "Haha, very funny. Did you hit your head or something?";
			Choice1a.SetActive(false);
			Choice1b.SetActive(false);
			allowSpace = true;
			nextButton.SetActive(true);
			primeInt = 100;
		}
		public void Choice1bFunct(){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "Think you need to work on your sense of humor, Rei. This isn't funny.";
			Choice1a.SetActive(false);
			Choice1b.SetActive(false);
			allowSpace = true;
			nextButton.SetActive(true);
			primeInt = 200;
		}
		public void Choice1cFunct(){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Whatever, he was overexaggeating. Who needs perfect anyways?";
			allowSpace = true;
			nextButton.SetActive(true);
			primeInt = 300;
			Choice1c.SetActive(false);
			Choice1d.SetActive(false);
		}
		public void Choice1dFunct(){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "Rei... I gotta find some way to fix this.";
			allowSpace = true;
			nextButton.SetActive(true);
			primeInt = 400;
			Choice1c.SetActive(false);
			Choice1d.SetActive(false);
		}
		public void SceneChange1(){
			SceneManager.LoadScene("End_LoseRei");
		}
		public void SceneChange2(){
			SceneManager.LoadScene("Scene7B");
		}
}