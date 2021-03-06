using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene5ADialogue : MonoBehaviour {
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
		ArtCharB1.SetActive(false);
		ArtCharB2.SetActive(false);
		ArtCharB3.SetActive(false);
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
                Char2speech.text = "You decide to stick around, waiting for Reyes to finish their detention sentence. Afterwards, you're led all the way to a clothing store.";
		 }
		 	else if (primeInt == 3){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "Various clothes lined the windows, sparkling for passerbys to see.";
		 }
		 		 		 else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "Just as you're about to make your way inside, someone familiar exits the building.";
		}
				 else if (primeInt == 5){
				ArtCharB2.SetActive(true);
                Char1name.text = "Lila";
                Char1speech.text = "Oh my gosh! Hey " + playerName + "! It's been so long since I last saw you!";
                Char2name.text = "";
                Char2speech.text = "";
		 }
		 		 else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Yeah! Hey Lila, it's been a while.";
		 }
		 		 else if (primeInt == 7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "You feel the grip on your shoulder tighten. You glance back at Reyes.";
		 }
		 		 else if (primeInt == 8){
					 ArtCharB2.SetActive(false);
					 ArtCharB1.SetActive(true);
                Char1name.text = "Lila";
                Char1speech.text = "Who's this? New friend of yours?";
                Char2name.text = "";
                Char2speech.text = "";
		 }
		 		 else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "Just as you're about to respond, Reyes speaks first.";
		 }
		 		 else if (primeInt == 10){
					 ArtCharB1.SetActive(false);
					 ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Reyes";
                Char2speech.text = "Yeah, what's it to you?";
		 }
		 		 else if (primeInt == 11){
					 ArtCharB1.SetActive(true);
					 ArtChar3.SetActive(false);
                Char1name.text = "Lila";
                Char1speech.text = "Nothing nothing. I just wanted to know who was clinging onto my bestie like a lost puppy.";
                Char2name.text = "";
                Char2speech.text = "";
		 }
		 		 else if (primeInt == 12){
					 ArtCharB1.SetActive(false);
					 ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Reyes";
                Char2speech.text = "...";
		 }
		 		 else if (primeInt == 13){
					 ArtChar3.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "The air gets tense as the three of you stand in silence.";
		 }
		 		 else if (primeInt == 14){
				allowSpace = false;
				nextButton.SetActive(false);
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
		 }
		
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
			ArtCharB3.SetActive(true);
                Char1name.text = "Lila";
                Char1speech.text = "I was just kidding, no need to take it so seriously.";
                Char2name.text = "";
                Char2speech.text = "";
				primeInt = 899;
        }
				 else if (primeInt == 900){
				ArtCharB3.SetActive(false);
				ArtCharB2.SetActive(true);
                Char1name.text = "Lila";
                Char1speech.text = "Anyway, got a date to the homecoming yet? I heard your school goes hard!";
                Char2name.text = "";
                Char2speech.text = "";
				primeInt = 100;
		 }
		else if (primeInt == 101){
				allowSpace = false;
				nextButton.SetActive(false);
			Choice1c.SetActive(true); // function Choice1aFunct()
            Choice1d.SetActive(true); // function Choice1bFunct()
		}

		 else if (primeInt == 200){
			 ArtCharB1.SetActive(false);
			 ArtCharB2.SetActive(true);
			 ArtCharB3.SetActive(false);
                Char1name.text = "Lila";
                Char1speech.text = "Haha! You still got it!";
                Char2name.text = "";
                Char2speech.text = "";
				primeInt = 899;
		 }

		else if (primeInt == 300){
			ArtCharB1.SetActive(false);
			ArtCharB2.SetActive(true);
			Char1name.text = "Lila";
                Char1speech.text = "Boring without you! I wish you didn't haven to transfer out. Miss all the chaos we used to cause together.";
                Char2name.text = "";
                Char2speech.text = "";
		}
				 else if (primeInt == 301){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Tell me about it. But I'm not a complete goody-two shoes! I'm technically skipping out on assignments as we speak!";
		 }
				 else if (primeInt == 302){
                Char1name.text = "Lila";
                Char1speech.text = "Ooh, you're so bad.";
                Char2name.text = "";
                Char2speech.text = "";
		 }
		 		 else if (primeInt == 303){
                Char1name.text = "Lila";
                Char1speech.text = "I'd love to stay longer and chat but I gotta dash. Got places to be, things to wreck. You remember how it is!";
                Char2name.text = "";
                Char2speech.text = "";
		 }
		 		 else if (primeInt == 304){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Couldn't forget even if I tried.";
		 }
		 		 else if (primeInt == 305){
					 ArtCharB2.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "You wave goodbye as Lila walks off into the distance.";
		 }
		 		 else if (primeInt == 306){
				ArtChar1.SetActive(true);
                Char1name.text = "Reyes";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
		 }
		 		 else if (primeInt == 307){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "I'm sorry about her. She's always been a bit of a nut case. No filter at all.";
		 }
		 		 else if (primeInt == 308){
					 ArtChar1.SetActive(false);
					 ArtChar3.SetActive(true);
                Char1name.text = "Reyes";
                Char1speech.text = "...Do I really cling onto you?";
                Char2name.text = "";
                Char2speech.text = "";
		 }
		 		 else if (primeInt == 309){
				allowSpace = false;
				nextButton.SetActive(false);
                Choice1e.SetActive(true); // function Choice1aFunct()
				Choice1f.SetActive(true); // function Choice1bFunct()
		 }
				 
				 
				 else if (primeInt == 400){
					 ArtCharB1.SetActive(true);
					 ArtCharB2.SetActive(false);
                Char1name.text = "Lila";
                Char1speech.text = "Oh, that's too sad then. Hey. Worst case scenario, you can be my date. Run it back just like we did last year!";
                Char2name.text = "";
                Char2speech.text = "";
		 }
		 		 else if (primeInt == 401){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "You know it! Anyway, how're things back in Ravendale?";
				primeInt = 299;
		 }
				 else if (primeInt == 500){
					 ArtChar3.SetActive(true);
                Char1name.text = "Reyes";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
		 }
		 		 else if (primeInt == 501){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "Without another word, Reyes leaves.";
				if (gameHandler.CheckPlayerStat()<=0){
					primeInt = 700;
				}				
		 }
		 else if (primeInt == 502){
				nextButton.SetActive(false);
                allowSpace = false;
				NextScene1Button.SetActive(true);
		 }

		 
		 		 else if (primeInt == 600){
					 ArtChar3.SetActive(false);
					 ArtChar2.SetActive(true);
                Char1name.text = "Reyes";
                Char1speech.text = "Heh, right. Just stupid stuff that stupid people say.";
                Char2name.text = "";
                Char2speech.text = "";
				}
				
			else if (primeInt == 601){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "See? You get it. C'mon. Let's go.";
				if (gameHandler.CheckPlayerStat()<=0){
					primeInt = 700;
				}
		 }
		 		 else if (primeInt == 602){
				nextButton.SetActive(false);
                allowSpace = false;
				NextScene1Button.SetActive(true);
		 }		
				else if (primeInt == 701){
				nextButton.SetActive(false);
                allowSpace = false;
				NextScene2Button.SetActive(true);
				}
}
// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Hey, Lila. Cut it out. Reyes is a good friend of mine. It's rude to talk to someone like that.";
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
                Char2name.text = playerName;
                Char2speech.text = "I know right? I mean, he's not that bad I guess. Good to have around.";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
				gameHandler.UpdatePlayerStat(-1);
        }
		public void Choice1cFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Of course I do! Who do you take me for? How're things doing back in Ravendale?";
                primeInt = 299;
                Choice1c.SetActive(false);
                Choice1d.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
				gameHandler.UpdatePlayerStat(1);
        }
		public void Choice1dFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "No, still haven't found anyone yet. Looking around to find the right person's hard in a stuck up private school.";
                primeInt = 399;
                Choice1c.SetActive(false);
                Choice1d.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
				gameHandler.UpdatePlayerStat(-1);
        }
		public void Choice1eFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Gotta be a little honest, you do follow me around everywhere. But I also do it to you so it's mutual!";
                primeInt = 499;
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
                Char2speech.text = "Don't listen to what she said, really. She's always read people wrong in the past.";
                primeInt = 599;
                Choice1e.SetActive(false);
                Choice1f.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
				gameHandler.UpdatePlayerStat(1);
		}

        public void SceneChange1(){
               SceneManager.LoadScene("Scene6A");
        }
		
		public void SceneChange2(){
				SceneManager.LoadScene("Scene6ABad");
		}
}
