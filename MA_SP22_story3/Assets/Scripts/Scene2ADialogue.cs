using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2ADialogue : MonoBehaviour {
		public string playerName;
		public GameHandler gameHandler;
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
        public GameObject ArtBG1;
		public GameObject ArtBG2;
        public GameObject Choice1a;
        public GameObject Choice1b;
		public GameObject Choice1c;
		public GameObject Choice1d;
        public GameObject NextScene1Button;
       // public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
		string pNameTemp = gameHandler.GetName();
		playerName = pNameTemp.ToUpper();
        DialogueDisplay.SetActive(false);
        ArtChar1.SetActive(false);
		ArtChar2.SetActive(false);
		ArtChar3.SetActive(false);
        ArtBG1.SetActive(true);
		ArtBG2.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice1c.SetActive(false);
        Choice1d.SetActive(false);
        NextScene1Button.SetActive(false);
        //NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
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
                 //AudioSource.Play();
        }
		else if (primeInt == 2){
			DialogueDisplay.SetActive(true);
			ArtBG2.SetActive(true);
			ArtBG1.SetActive(false);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "";
			Char2speech.text = "In the corner of your eye, you see a figure leaning on the wall near the window. You lock eyes for a moment. Curiosity gets the better of you and you approach them.";
		}
        else if (primeInt == 3){
			DialogueDisplay.SetActive(true);
                Char1name.text = "???";
                Char1speech.text = "Huh, so you decided to skip too? It’s a waste of time anyway so you made a good decision I guess.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==4){
                Char1name.text = "";
                Char1speech.text = "";
				Char2name.text = playerName;
                Char2speech.text = "";
				Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
                //gameHandler.AddPlayerStat(1);
        }
        
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                Char1name.text = "???";
                Char1speech.text = "What’s the point in going when there’s nothing lined up for me?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 101){
                Char1name.text = "???";
                Char1speech.text = "It’s not like it’d amount to anything. It’s a waste of time for someone like me.";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 102){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "What do you mean “For someone like you”?";
        }
		else if (primeInt == 103){
                Char1name.text = "???";
                Char1speech.text = "Take a good look at me. Is there anything that seems different about me compared to the other students?";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 104){
                Char1name.text = "";
                Char1speech.text = "";
                //Char2name.text = playerName;
                Char2speech.text = "You take a good look at him. You choose to comment on his...";
				Choice1c.SetActive(true); // function Choice1aFunct()
                Choice1d.SetActive(true); // function Choice1bFunct()
        }
		else if (primeInt == 155){
			ArtChar3.SetActive(true);
			ArtChar1.SetActive(false);
                Char1name.text = "???";
                Char1speech.text = "Tch, you blind or something? How does my hair even- You know what, forget it. I’ll just tell you. I’ve been held back a few years…";
                Char2name.text = "";
                Char2speech.text = "";
				primeInt =160;
				
        }
		else if (primeInt == 160){
			ArtChar2.SetActive(true);
			ArtChar3.SetActive(false);
			ArtChar1.SetActive(false);
                Char1name.text = "???";
                Char1speech.text = "Heh, keen eyes you got there. Yup, you figured me out, I’m older than most students. I’ve been held back a few years but it’s whatever.";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 161){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Yeah? What’s been holding you back?";
		}
		else if (primeInt == 162){
			ArtChar1.SetActive(true);
			ArtChar2.SetActive(false);
			ArtChar3.SetActive(false);
                Char1name.text = "???";
                Char1speech.text = "Wouldn’t you like to know, looking for something to laugh at huh?";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 163){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Yeesh, I was curious. Fine, don’t tell me.";
		}
else if (primeInt == 164){
                Char1name.text = "???";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
		}
else if (primeInt == 165){
			ArtChar3.SetActive(true);
			ArtChar1.SetActive(false);
                Char1name.text = "???";
                Char1speech.text = "...bio.";
                Char2name.text = "";
                Char2speech.text = "";
		}
else if (primeInt == 166){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Bio?";
		}
else if (primeInt == 167){
                Char1name.text = "???";
                Char1speech.text = "As in, Biology yes. All because I can never remember that thing that gives cells power ups or something.";
                Char2name.text = "";
                Char2speech.text = "";
		}
else if (primeInt == 168){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "You mean the Mitochondria? The powerhouse of the cell?";
		}
else if (primeInt == 169){
                Char1name.text = "???";
                Char1speech.text = "That, whatever it is. It’s just so stupid. Why would I need to know that anyway? School’s a joke.";
                Char2name.text = "";
                Char2speech.text = "";
				primeInt =184;
		}
		else if (primeInt == 185){
                Char1name.text = "???";
                Char1speech.text = "All these sheep here can’t even see it for what it is, all just chasing Grades. As if those ever mean anything.";
                Char2name.text = "";
                Char2speech.text = "";
				primeInt =169;
		}
else if (primeInt == 170){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "I get ya, dude.";
		}
else if (primeInt == 171){
				ArtChar2.SetActive(true);
				ArtChar3.SetActive(false);
                Char1name.text = "???";
                Char1speech.text = "Yeah? You know, no one’s ever really… understood my perspective before. It’s actually kind of weird.";
                Char2name.text = "";
                Char2speech.text = "";
		}
else if (primeInt == 172){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "I mean, you’re right. School is a big scam.";
		}
else if (primeInt == 173){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "They teach us a bunch of crud you’ll never use in your life, and make us wake up early to learn said crud as they wave a grade in our face for us to get.";
		}
else if (primeInt == 174){
                Char1name.text = "???";
                Char1speech.text = "Heh, maybe you really do get it. There’s nothing for us here, that much is clear. Knowing that doesn’t make me any less of a failure though.";
                Char2name.text = "";
                Char2speech.text = "";
}
else if (primeInt == 175){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Dude, forget all these idiots. My parents paid big money for me to go here and I couldn’t care less.";
}
else if (primeInt == 176){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "They made me leave my old school, my old life for this snobby place. Straight A’s and high honors here but that ain’t me.";
}
else if (primeInt == 177){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Grades don’t define you, I don’t think you’re a failure, you’re smarter than everyone here.";
}
else if (primeInt == 178){
				ArtChar1.SetActive(true);
				ArtChar2.SetActive(false);
                Char1name.text = "???";
                Char1speech.text = "…! I… Ehem- Maybe you’re not completely wrong I guess.";
                Char2name.text = "";
                Char2speech.text = "";
}
else if (primeInt == 179){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Lighten up, while everyone else is slaving in class we’re chilling, doing what they wish they could.";
}
else if (primeInt == 180){
				ArtChar2.SetActive(true);
				ArtChar1.SetActive(false);
                Char1name.text = "???";
                Char1speech.text = "Hehe, yeah I guess so. I don’t care what they’re feeling though, as long as I’m content is what matters. I look out for me, everyone is whatever…";
                Char2name.text = "";
                Char2speech.text = "";
}
else if (primeInt == 181){
                Char1name.text = "???";
                Char1speech.text = "But you know, this has been strangely… not bad hanging with you. ";
                Char2name.text = "";
                Char2speech.text = "";
				primeInt = 181;
}
else if (primeInt == 185){
                Char1name.text = "???";
                Char1speech.text = "I would have been alright out here on my own, you being here wouldn’t make a difference or anything so it’s whatever.";
                Char2name.text = "";
                Char2speech.text = "";
				primeInt = 181;
}
else if (primeInt == 182){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Heh, sure.";
}
else if (primeInt == 183){
				ArtChar1.SetActive(true);
				ArtChar2.SetActive(false);
                Char1name.text = "Reyes";
                Char1speech.text = "The name’s Reyes by the way, not that it really matters.";
                Char2name.text = "";
                Char2speech.text = "";
}
else if (primeInt == 184){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Good to meet ya, Reyes. My name is " + playerName + ".";
				primeInt = 185;
}

else if (primeInt == 187){
				nextButton.SetActive(false);
                allowSpace = false;
				NextScene1Button.SetActive(true);
        }

		

       else if (primeInt == 200){
				ArtChar3.SetActive(true);
				ArtChar1.SetActive(false);
                Char1name.text = "???";
                Char1speech.text = "Are you deaf? Aren't you going to answer my question?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 201){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Sorry! You just surprised me.";
	   }
	   else if (primeInt == 202){
                Char1name.text = "???";
                Char1speech.text = "Tsk. What a waste of time school is. Espcially for someone like me.";
                Char2name.text = "";
                Char2speech.text = "";
				primeInt =101;
	   }
                //nextButton.SetActive(false);
                //allowSpace = false;
                //NextScene2Button.SetActive(true);
        //}
}

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
				ArtChar1.SetActive(true);
                ArtBG2.SetActive(false);
				ArtBG1.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "What about you? I don't see you exactly being the model student.";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
			ArtChar1.SetActive(true);
                ArtBG2.SetActive(false);
				ArtBG1.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Huh? Who are you?";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice1cFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Your hair...";
                primeInt = 154;
                Choice1c.SetActive(false);
                Choice1d.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice1dFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Your appearance...";
                primeInt = 159;
                Choice1c.SetActive(false);
                Choice1d.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene3");
        }
}
