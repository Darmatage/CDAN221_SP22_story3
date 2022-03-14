using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene5CDialogue : MonoBehaviour {
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
                Char2speech.text = "You follow Luka until you're stopped at a store that you haven't been to since your move.";
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
				ArtChar1.SetActive(true);
				ArtCharB2.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Luka";
                Char2speech.text = "Oh? Who's this " + playerName + "?";
		 }
		 		 else if (primeInt == 8){
				ArtChar1.SetActive(false);
				ArtCharB2.SetActive(true);
                Char1name.text = "Lila";
                Char1speech.text = "Oh my gosh! You must be Luka! " + playerName + " just couldn't stop talking about you! Especially when they first came to Ravendale.";
                Char2name.text = "";
                Char2speech.text = "";
		 }
		 		 else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Shut it, Lila.";
		 }
		 		 else if (primeInt == 10){
                Char1name.text = "Lila";
                Char1speech.text = "What? It's totally true though!";
                Char2name.text = "";
                Char2speech.text = "";
		 }
		 		 else if (primeInt == 11){;
				 ArtCharB2.SetActive(false);
				 ArtChar3.SetActive(true);
                Char1name.text = "Luka";
                Char1speech.text = "O-oh! Ha...ha. I see!";
                Char2name.text = "";
                Char2speech.text = "";
		 }
		 		 else if (primeInt == 12){
					 ArtChar3.SetActive(false);
					 ArtCharB2.SetActive(true);
                Char1name.text = "Lila";
                Char1speech.text = "So awesome that you two are finally reunited. It's great to see you so happy, bestie.";
                Char2name.text = "";
                Char2speech.text = "";
		 }
		 		 else if (primeInt == 13){
					 ArtCharB2.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "Everythings falls silents as the final word leaves their mouth. You freeze and glance at Luka.";
		 }
				else if (primeInt == 14){
					ArtChar2.SetActive(true);
				Char1name.text = "Luka";
				Char1speech.text = "Y-yeah! It's so great to see them so happy! They always had the best smiles!";
				Char2name.text  = "";
				Char2speech.text = "";
				primeInt = 101;
				}
		
// ENCOUNTER AFTER CHOICE #1
				else if (primeInt == 102) {
					ArtCharB2.SetActive(true);
					ArtChar2.SetActive(false);
					Char1name.text = "Lila";
					Char1speech.text = "Anyway, got any ideas for your date to the homecoming? Heard your school goes hard on it every year.";
					Char2name.text = "";
					Char2speech.text = "";
				}
		else if (primeInt == 103){
			Choice1c.SetActive(true); // function Choice1aFunct()
            Choice1d.SetActive(true); // function Choice1bFunct()
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
                Char2speech.text = "Tell me about it. I've been trying to turn over a new leaf but I get into a few scuffles every now and then.";
		 }
				 else if (primeInt == 302){
                Char1name.text = "Lila";
                Char1speech.text = "Ooh, goody two shoes. I see what you're doing. Well, don't let me get in the way of that!";
                Char2name.text = "";
                Char2speech.text = "";
		 }
		 		 else if (primeInt == 303){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "But hey. If you ever need backup, you know who to call.";
		 }
		 		 else if (primeInt == 304){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "You flash Lila a quick smile with a devious look.";
		 }
		 		 else if (primeInt == 305){
                Char1name.text = "Lila";
                Char1speech.text = "You got it! Next scheme I cook up, I'll run right over to ya.";
                Char2name.text = "";
                Char2speech.text = "";
		 }
		 		 else if (primeInt == 306){
				ArtCharB2.SetActive(false);
				ArtCharB1.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
				Char2name.text = playerName;
                Char1speech.text = "It's a date!";
				 }
				 else if (primeInt == 307){
				Char1name.text = "Lila";
                Char1speech.text = "Well! Gotta dash. People to bother, places to wreck. You know how it is!";
				Char2name.text = "";
                Char2speech.text = "";
				 }
				 
				else if (primeInt == 308){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Couldn't even if I tried! See ya around!";
		 }
		 		 else if (primeInt == 309){
					 ArtCharB1.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "I'm sorry about her.";
		 }
		 		 else if (primeInt == 310){
					 ArtChar3.SetActive(true);
                Char1name.text = "Luka";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
		 }
				else if (primeInt == 311){
				Char1name.text = "Luka";
                Char1speech.text = "Was what they said true? Were you really their bestie?";
				Char2name.text = "";
                Char2speech.text = "";
				}
		 		 else if (primeInt == 312){
                Choice1e.SetActive(true); // function Choice1aFunct()
				Choice1f.SetActive(true); // function Choice1bFunct()
		 }
				 
				 
				 else if (primeInt == 400){
					 ArtCharB2.SetActive(false);
					 ArtCharB1.SetActive(true);
                Char1name.text = "Lila";
                Char1speech.text = "Oh, that's too sad then. Hey. Worst case scenario, you can be my date. Run it back just like we did last year!";
                Char2name.text = "";
                Char2speech.text = "";
		 }
		 		 else if (primeInt == 401){
                Char1name.text = "";
                Char1speech.text = "";
				Char2name.text = "";
                Char2speech.text = "You feel the hold on your hand tighten. Your shrug it off.";
		 }
				else if (primeInt == 402){
					Char1name.text = "";
					Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "You know it! Anyway, how're things back in Ravendale anyway?";
				primeInt = 299;
				}
				 else if (primeInt == 500){
					 ArtChar3.SetActive(true);
                Char1name.text = "Luka";
                Char1speech.text = "O-oh...";
                Char2name.text = "";
                Char2speech.text = "";
		 }
		 		 else if (primeInt == 501){
                Char1name.text = "Luka";
                Char1speech.text = "I see...";
                Char2name.text = "";
                Char2speech.text = "";
		 }
				else if (primeInt == 502){
					Char1name.text = "";
					Char1speech.text = "";
					Char2name.text = "";
					Char2speech.text = "The two of you stand in silence before Luka pipes up.";
				}
				else if (primeInt == 503){
					Char1name.text = "Luka";
					Char1speech.text = "I.. I have to go.";
					Char2name.text = "";
					Char2speech.text = "";
				}
				else if (primeInt == 504){
					Char1name.text = "";
					Char1speech.text = "";
					Char2name.text = "";
					Char2speech.text = "Without another word, Luka runs away before you can say a word..";
				}
				
		 else if (primeInt == 505){
				nextButton.SetActive(false);
                allowSpace = false;
				NextScene1Button.SetActive(true);
		 }

		 
		 		 else if (primeInt == 600){
					 ArtChar3.SetActive(true);
                Char1name.text = "Luka";
                Char1speech.text = "Well, their joke wasn't very funny...";
                Char2name.text = "";
                Char2speech.text = "";
				}
				
			else if (primeInt == 601){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Haha... yeah.";
		 }
			else if (primeInt == 602){
				ArtChar3.SetActive(false);
				ArtChar2.SetActive(true);
				Char1name.text = "";
				Char1speech.text = "";
				Char2name.text = "";
				Char2speech.text = "Luka perks up with a smile.";
			}
			
			else if (primeInt == 603){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Luka";
                Char2speech.text = "Let's go inside! There's so much I gotta show you. They got this new shirt that I think would look perfect on you!";
			}
			else if (primeInt == 604){
				Char1name.text = "";
				Char1speech.text = "";
				Char2name.text = "";
				Char2speech.text = "Nodding, you follow along as you're pulled inside the store.";
			}
		 		 else if (primeInt == 605){
			nextButton.SetActive(false);
                allowSpace = false;
				NextScene1Button.SetActive(true);
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
		 

		
}
// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Just give me a few more minutes to talk. Then we can do whatever you have on that schedule of yours, okay?";
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
                Char2speech.text = "Buzz off, man. She's my friend. I can do whatever I want.";
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
                Char2speech.text = "Well, it's not like I can just not make friends in a new school right? They were a great friend to me when I was alone.";
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
                Char2speech.text = "Nah, I wouldn't listen to them. They were the joker and looks like they're keeping that act up!";
                primeInt = 599;
                Choice1e.SetActive(false);
                Choice1f.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
				gameHandler.UpdatePlayerStat(1);
		}

        public void SceneChange1(){
               SceneManager.LoadScene("Scene6C");
        }
}
