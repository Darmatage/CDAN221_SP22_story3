using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene3Dialogue : MonoBehaviour {
        public int primeInt = 1;         // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        //public Text Char2name;
        //public Text Char2speech;
       //public Text Char3name;
       //public Text Char3speech;
        public GameObject DialogueDisplay;
		public GameObject Gift1;
		public GameObject Gift2;
		public GameObject Gift3;
        //public GameObject ArtChar1;
       //public GameObject ArtChar2;
        public GameObject ArtBG1;
		public GameObject ArtBG2;
        public GameObject Choice1a;
        public GameObject Choice1b;
		public GameObject Choice1c;
		//public GameObject Choice1d;
		//public GameObject Choice1e;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
		public GameObject NextScene3Button;
        public GameObject nextButton;
		public string playerName;
		public GameHandler gameHandler;
       //public GameHandler gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
		string pNameTemp = gameHandler.GetName();
		playerName = pNameTemp.ToUpper();
        DialogueDisplay.SetActive(false);
        //ArtChar1.SetActive(false);
		Gift1.SetActive(false);
		Gift2.SetActive(false);
		Gift3.SetActive(false);
        ArtBG1.SetActive(true);
		ArtBG2.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice1c.SetActive(false);
		//Choice1d.SetActive(false);
		//Choice1e.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
		NextScene3Button.SetActive(false);
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
                Char1speech.text = "The next day...";

        }
       else if (primeInt ==3){
		   ArtBG1.SetActive(false);
		   ArtBG2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "You head to your locker in order to store your bag for the day.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "Inside, there lay three gifts.";
        }
       else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "The first one is messily wrapped, as if it was done in a rush. Tape covers the entire thing.";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "The second one is perfectly wrapped. It looks so pristine, it doesn't feel like a real object.";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "The third one is normally wrapped. It's rough in some parts but you can tell there was care taken into wrapping it. ";
        }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "Your hand reaches out and grabs...";
	   }
	   else if (primeInt == 9){
                // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
				Choice1c.SetActive(true); // function Choice1bFunct()
        }
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                Char1name.text = "";
                Char1speech.text = "You smile to yourself, already knowing who it was that would even bother with the gift.";
        }
		else if (primeInt == 101){
				NextScene1Button.SetActive(true);
		}
		
		else if (primeInt == 200){
				Char1name.text = "";
				Char1speech.text = "You're rendered speechless as you examine the necklace one more time. In your gut, you knew who it was from.";
		}
		else if (primeInt == 201){
				NextScene2Button.SetActive(true);
		}
		
		else if (primeInt == 300) {
				Char1name.text = "";
                Char1speech.text = "You smile as you recall a memory. A very similar bracelet from childhood came to mind as you stared at the bracelet in your hand.";
		}
		else if (primeInt == 301) {
				NextScene3Button.SetActive(true);
		}
     }

	

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
				Gift1.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "You open the first box, finding an earring. Somehow, the design looks familiar to you.";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
				Gift2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "You open the second box and find a necklace with a lock and key charm attached. It looks to be made of gold with a diamond in the middle.";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		public void Choice1cFunct(){
				Gift3.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "The third box contained a bracelet with a heart charm. It looks handmade.";
                primeInt = 299;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
           
        public void SceneChange1(){
               SceneManager.LoadScene("Scene4a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene4b");
        }
		public void SceneChange3(){
                SceneManager.LoadScene("Scene4c");
        }
}