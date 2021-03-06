using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2CDialogue : MonoBehaviour {
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
        public GameObject NextScene1Button;
        //public GameObject NextScene2Button;
        public GameObject nextButton;
		//public GameHandler gameHandler;
		//public AudioSource audioSource;
        private bool allowSpace = true;
		public string playerName;
		public GameHandler gameHandler;


void Start(){         // initial visibility settings
		string pNameTemp = gameHandler.GetName();
		playerName = pNameTemp.ToUpper();
        DialogueDisplay.SetActive(false);
        ArtChar1.SetActive(false);
		ArtChar2.SetActive(false);
		ArtChar3.SetActive(false);
        ArtBG1.SetActive(false);
		ArtBG2.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
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
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "You decide to head inside. Suddenly someone barges into the classroom and locks eyes with you.";
        }
       else if (primeInt ==3){
		   ArtBG1.SetActive(false);
		   ArtBG2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "It???s a childhood friend that you had lost contact with years ago.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "???";
                Char1speech.text = "When I saw your name, I just knew it had to be fate! I can???t believe it???s been so long since I last saw you!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
        }
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
				ArtChar2.SetActive(true);
                Char1name.text = "Luka";
                Char1speech.text = "Aw shucks, it couldn't have been that long for you to forget! It's me! Luka!";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 101){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Right. Luka. It's been a while. I haven't seen you since the move!";
				primeInt = 201;
		}

       else if (primeInt == 200){
				ArtChar2.SetActive(true);
                Char1name.text = "Luka";
                Char1speech.text = "Yaaaaaay! I just knew you'd remember me, you just had to!";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 201){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Gosh. It???s been so long, Luka. I haven???t seen you since the big move.";
		}
		else if (primeInt == 202){
                Char1name.text = "Luka";
                Char1speech.text = "I know RIGHT? I was devastated I couldn???t see you again.";
                Char2name.text = "";
                Char2speech.text = "";
}
		else if (primeInt == 203){
                Char1name.text = "Luka";
                Char1speech.text = "I was going crazy being away from you. Did you miss me? Did you? I bet you did, I missed you!";
                Char2name.text = "";
                Char2speech.text = "";
}
				else if (primeInt == 204){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "I missed you too Luka, I still can???t believe it???s really you here right now. It???s almost as if-";
}
		else if (primeInt == 205){
                Char1name.text = "Luka";
                Char1speech.text = "That it was meant to be? I toooootally agree! I???m so excited to catch up with you. We???re gonna have so much fun together again!";
                Char2name.text = "";
                Char2speech.text = "";
}
		else if (primeInt == 206){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Gee I sure wish, school isn???t exactly the funnest place in the world really.";
}
		else if (primeInt == 207){
                Char1name.text = "Luka";
                Char1speech.text = "Aww, don't sweat that! Anything is a blast when we???re together! I swear, we???ll never be apart again.";
                Char2name.text = "";
                Char2speech.text = "";
}
		else if (primeInt == 208){
                Char1name.text = "Luka";
                Char1speech.text = "In fact, engrave it in your brain, tattoo it to your body because you???re never gonna forget your bestest, bestie, Luka!";
                Char2name.text = "";
                Char2speech.text = "";
}
else if (primeInt == 209){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "You always were funny Luka, what have you been up to these days";
}
		else if (primeInt == 210){
                Char1name.text = "Luka";
                Char1speech.text = "Thinking about you, silly! Ever since you left things just haven???t been the same???";
                Char2name.text = "";
                Char2speech.text = "";
}
		else if (primeInt == 211){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "What do you mean? How so?";
}
		else if (primeInt == 212){
				ArtChar2.SetActive(false);
				ArtChar3.SetActive(true);
                Char1name.text = "Luka";
                Char1speech.text = "The day you left really hit me. You know, you were the only one I had.";
                Char2name.text = "";
                Char2speech.text = "";
}
		else if (primeInt == 213){
                Char1name.text = "Luka";
                Char1speech.text = "The only one I knew. The only one who kept me around??? When you left, I was left with nothing.";
                Char2name.text = "";
                Char2speech.text = "";
}
		else if (primeInt == 214){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Luka, I???m so sorry. My family told me we were leaving and I couldn???t say good bye, there was no time.";
}
		else if (primeInt == 215){
				ArtChar2.SetActive(true);
				ArtChar3.SetActive(false);
                Char1name.text = "Luka";
                Char1speech.text = "That???s OoooOooookey! All that???s in the past right?";
                Char2name.text = "";
                Char2speech.text = "";
}
		else if (primeInt == 216){
                Char1name.text = "Luka";
                Char1speech.text = "I mean yeah, I did enter a state of spiraling depression having lost the only person I ever had.";
                Char2name.text = "";
                Char2speech.text = "";
}
		else if (primeInt == 217){
                Char1name.text = "Luka";
                Char1speech.text = "But it???s all good now, because we???re never gonna be apart again! I???ll make sure of it??? I???ll never be alone again, not ever???hahahaHA.";
                Char2name.text = "";
                Char2speech.text = "";
}
		else if (primeInt == 218){
				nextButton.SetActive(false);
                allowSpace = false;
				NextScene1Button.SetActive(true);
				
		}
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Hey uhhh... Yuka right?";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
				ArtBG1.SetActive(true);
				ArtBG2.SetActive(false);
        }
        public void Choice1bFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Luka!";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
				ArtBG1.SetActive(true);
				ArtBG2.SetActive(false);
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene3");
        }
}