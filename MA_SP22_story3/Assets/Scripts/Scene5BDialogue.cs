using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene5BDialogue : MonoBehaviour {
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
                Char2speech.text = "Rei takes your hand and takes you to a familiar boutique.";
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
                Char2speech.text = "You hear a scoff from behind you.";
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
					  ArtCharB1.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "Just as you're about to talk, Rei responds.";
		 }
		 		 else if (primeInt == 10){
					 ArtChar3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Rei";
                Char2speech.text = "I'm sorry, we don't have time for this. Now if you'll excuse us.";
		 }
		 		 else if (primeInt == 11){;
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Rei! Be nice! This is my best friend, Lila, from my old school.";
		 }
		 		 else if (primeInt == 12){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Rei";
                Char2speech.text = "I'm sorry, did I stutter? I said, we don't have time. We're on a tight schedule and clearly your 'friend' here isn't a part of it.";
		 }
		 		 else if (primeInt == 13){
					 ArtChar3.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "The air gets tense as the three of you stand in silence.";
		 }
		 		 else if (primeInt == 14){
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
		 }
		
       else if (primeInt == 100){
			ArtChar3.SetActive(true);
                Char1name.text = "Rei";
                Char1speech.text = "Very well. I will allow you five minutes. Nothing more.";
                Char2name.text = "";
                Char2speech.text = "";
        }
				 else if (primeInt == 101){;
				 ArtChar3.SetActive(false);
				ArtCharB3.SetActive(true);
                Char1name.text = "Lila";
                Char1speech.text = "Yeesh, what a buzz kill.";
                Char2name.text = "";
                Char2speech.text = "";
		 }
				else if (primeInt == 102) {
					ArtCharB2.SetActive(true);
					ArtCharB3.SetActive(false);
					Char1name.text = "Lila";
					Char1speech.text = "Anyway, got any ideas for your date to the homecoming? Heard your school goes hard on it every year.";
					Char2name.text = "";
					Char2speech.text = "";
				}
		else if (primeInt == 103){
			Choice1c.SetActive(true); // function Choice1aFunct()
            Choice1d.SetActive(true); // function Choice1bFunct()
		}

		 else if (primeInt == 200){
			 ArtCharB1.SetActive(false);
			 ArtCharB2.SetActive(false);
			 ArtCharB3.SetActive(true);
                Char1name.text = "Lila";
                Char1speech.text = "Yeah dude. They're not some robot that's going to listen to your every command.";
                Char2name.text = "";
                Char2speech.text = "";
				primeInt = 101;
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
                Char2speech.text = "Tell me about it. I've been a bit busy lately to cause too much havoc.";
		 }
				 else if (primeInt == 302){
                Char1name.text = "";
                Char1speech.text = "Your eyes quickly point towards Rei before you resume your conversation.";
                Char2name.text = "";
                Char2speech.text = "";
		 }
		 		 else if (primeInt == 303){
                Char1name.text = "Lila";
                Char1speech.text = "I gotcha. No need to worry about that. I'm sure you'll find one way or another.";
                Char2name.text = "";
                Char2speech.text = "";
		 }
		 		 else if (primeInt == 304){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "You flash Lila a quick smile with a devious look.";
		 }
		 		 else if (primeInt == 305){
					 ArtCharB2.SetActive(false);
					 ArtCharB1.SetActive(true);
                Char1name.text = "Lila";
                Char1speech.text = "Well, gotta dash! You know how things are, never enough time in the day for all the plans I got.";
                Char2name.text = "";
                Char2speech.text = "";
		 }
		 		 else if (primeInt == 306){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Couldn't even if I tried! See ya around!";
		 }
		 		 else if (primeInt == 307){
					 ArtCharB1.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "I'm sorry about her.";
		 }
		 		 else if (primeInt == 308){
					 ArtChar3.SetActive(true);
                Char1name.text = "Rei";
                Char1speech.text = "Was what they said true? That you used to cause mayhem for those around you?";
                Char2name.text = "";
                Char2speech.text = "";
		 }
		 		 else if (primeInt == 309){
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
                Char2speech.text = "You hear a scoff from Rei. Your shrug it off.";
		 }
				else if (primeInt == 402){
					Char1name.text = "";
					Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "You know it! Anyway, how're things back in Ravendale?";
				primeInt = 299;
				}
				 else if (primeInt == 500){
					 ArtChar3.SetActive(true);
                Char1name.text = "Rei";
                Char1speech.text = "Is that so...";
                Char2name.text = "";
                Char2speech.text = "";
		 }
		 		 else if (primeInt == 501){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "Rei stares off into the distance. They turn their head towards you.";
		 }
				else if (primeInt == 502){
					Char1name.text = "";
					Char1speech.text = "";
					Char2name.text = "Rei";
					Char2speech.text = "It appears I have some other business to take care of. I bid you farewell.";
			}
				 else if (primeInt == 503){
					 Char1name.text = "";
					 Char1speech.text = "";
					 Char2name.text = "";
					 Char2speech.text = "Rei doesn't spare you another glance as they leave you behind.";
					 if (gameHandler.CheckPlayerStat()<=0){
					primeInt = 700;
				 }
				}
		 else if (primeInt == 503){
				nextButton.SetActive(false);
                allowSpace = false;
				NextScene1Button.SetActive(true);
		 }

		 
		 		 else if (primeInt == 600){
					 ArtChar3.SetActive(false);
					 ArtChar1.SetActive(true);
                Char1name.text = "Rei";
                Char1speech.text = "If that's the case, I don't possibly understand why you tolerate them. It seems like they're a waste of space that shouldn't be given the time of day.";
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
				ArtChar1.SetActive(false);
				ArtChar2.SetActive(true);
				Char1name.text = "";
				Char1speech.text = "";
				Char2name.text = "";
				Char2speech.text = "Rei laughs before offering you their arm to take to lead you inside.";
			}
			
			else if (primeInt == 603){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Rei";
                Char2speech.text = "Now, let us be off.";
				if (gameHandler.CheckPlayerStat()<=0){
					primeInt = 700;
			}
			}
		 		 else if (primeInt == 604){
			nextButton.SetActive(false);
                allowSpace = false;
				NextScene1Button.SetActive(true);
		 }
		 else if (primeInt == 701){
				nextButton.SetActive(false);
                allowSpace = false;
				NextScene2Button.SetActive(true);
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
                Char2speech.text = "Just a little bit. Nothing too serious, just some graffiti here and there.";
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
                Char2speech.text = "Nah, I wouldn't listen to a word they said. They were the class clown and still looks like they're keeping that reputation up!";
                primeInt = 599;
                Choice1e.SetActive(false);
                Choice1f.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
				gameHandler.UpdatePlayerStat(1);
		}

        public void SceneChange1(){
               SceneManager.LoadScene("Scene6B");
        }
		
		public void SceneChange2(){
				SceneManager.LoadScene("Scene6BBad");
		}
}