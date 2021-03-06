using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene2BDialogue : MonoBehaviour {
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
		//public GameObject Choice1c;
		//public GameObject Choice1d;
        public GameObject NextScene1Button;
        //public GameObject NextScene2Button;
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
		//Choice1c.SetActive(false);
        //Choice1d.SetActive(false);
        NextScene1Button.SetActive(false);
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
                // AudioSource.Play();
        }
        else if (primeInt == 2){
                DialogueDisplay.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "At the cafeteria, the smell of food hits your nose. The line for healthier breakfasts seems packed but it is the healthier option. What do you do?";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
                //gameHandler.AddPlayerStat(1);
        }
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "You make your way towards the dessert counter where a sparkling donut seems to call out for you. Just as you're about to reach it, a hand grabs your wrist.";
        }
       else if (primeInt == 101){
				ArtChar1.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "H-hey! Lay off will you? That donut was calling out to me!";
        }
		else if (primeInt == 102){
                Char1name.text = "Rei";
                Char1speech.text = "Like YOU need any of that garbage. That???s the problem with everyone here, how anyone can stuff themselves with junk like this so early is beyond me.";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 103){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "I don't care, it's just one! How bad can it be?";
     }
		else if (primeInt == 104){
                Char1name.text = "Rei";
                Char1speech.text = "All it takes is one today, then two tomorrow. Next thing you know you???ll be living off these things. ";
                Char2name.text = "";
                Char2speech.text = "";
}
		else if (primeInt == 105){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "I think you???re overreacting, now stand aside as I nab a few cinnamon buns.";
}
		else if (primeInt == 106){
				ArtChar1.SetActive(false);
				ArtChar3.SetActive(true);
                Char1name.text = "Rei";
                Char1speech.text = "Hey, HEY! You can???t have those either! Look, everything here is BAD okay?";
                Char2name.text = "";
                Char2speech.text = "";
}
		else if (primeInt == 107){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Then what do you expect me to eat? Food???s in the cafeteria for a reason you know.";
}
		else if (primeInt == 108){
				ArtChar1.SetActive(true);
				ArtChar3.SetActive(false);
                Char1name.text = "Rei";
                Char1speech.text = "Why they do is beyond me. Should I know?";
                Char2name.text = "";
                Char2speech.text = "";
}
		else if (primeInt == 109){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "To EAT. It???s here for us to eat, now move. I'm late and hungry enough as it is.";
}
		else if (primeInt == 110){
                Char1name.text = "Rei";
                Char1speech.text = "I said no! I???m not letting another newbie fall prey to these fake cuisines, this is the last time I???d let that happen. Come on, you???re getting quality and that???s final.";
                Char2name.text = "";
                Char2speech.text = "";
}
		else if (primeInt == 111){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "I guess we're doing this.";
		}
		else if (primeInt == 112){
			ArtChar1.SetActive(false);
			ArtBG2.SetActive(true);
                Char1name.text = "Rei";
                Char1speech.text = "Here, try some of these. I???ve had them prepared and made fresh for peak delectable enjoyment.";
                Char2name.text = "";
                Char2speech.text = "";
}
		else if (primeInt == 113){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "Wow, this is incredible.";
}
		else if (primeInt == 114){
                Char1name.text = "Rei";
                Char1speech.text = "Well of course, I???ve had these tarts especially prepared for absolute perfection.";
                Char2name.text = "";
                Char2speech.text = "";
}
		else if (primeInt == 115){
                Char1name.text = "Rei";
                Char1speech.text = "Tell me, you must see the difference between this divine work of art and those trash holes you almost poisoned your tastes with, right?";
                Char2name.text = "";
                Char2speech.text = "";
}
		else if (primeInt == 116){
				ArtBG2.SetActive(false);
				ArtChar1.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "I??? I actually do, I don???t know how I can ever go back to eating donuts again after this.";
}
		else if (primeInt == 117){
                Char1name.text = "Rei";
                Char1speech.text = "My name is Rei, and today is the last time you live like some casual barbarian. Listen to exactly what I say and do exactly what I tell you and you might just be perfect.";
                Char2name.text = "";
                Char2speech.text = "";
}
		else if (primeInt == 118){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = playerName;
                Char2speech.text = "...perfect?";
		}
				else if (primeInt == 119){
                Char1name.text = "Rei";
                Char1speech.text = "Alright, breakfast is over. We???re leaving now, let???s go. And clear your schedule because we have much to do";
                Char2name.text = "";
                Char2speech.text = "";
}
		else if (primeInt == 120){
                nextButton.SetActive(false);
                allowSpace = false;
				NextScene1Button.SetActive(true);
				
}
}

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "You wait a while but the line doesn't seem to budge. You go elsewhere.";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "Your hunger gets the best of you. You make a beeline a less crowded area of the cafeteria.";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene3");
        }
}
