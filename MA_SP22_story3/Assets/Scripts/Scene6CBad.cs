using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Scene6CBad : MonoBehaviour {
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
		public GameObject Choice1e;
		public GameObject Choice1f;
		public GameObject Choice1g;
		public GameObject Choice1h;
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
		Choice1e.SetActive(false);
		Choice1f.SetActive(false);
		Choice1g.SetActive(false);
		Choice1h.SetActive(false);
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
   
   public void talking(){
	   DialogueDisplay.SetActive(true);
	    primeInt = primeInt + 1;
        if (primeInt == 1){
        }
		else if (primeInt == 2){
			DialogueDisplay.SetActive(true);
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "Several days later...";
		}
		else if (primeInt == 3){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "You see Luka in a corner by themself. With a wave, you approach.";
		}
		else if (primeInt == 4){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "Oh, hey Luka.";
		}
		else if (primeInt == 5){
			ArtChar4.SetActive(true);
			Char1name.text = "Luka";
            Char1speech.text = "Hisssssssssss.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 6){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "Huh? Why are you hissing at me?";
		}
		else if (primeInt == 7){
			Char1name.text = "Luka";
            Char1speech.text = "'oH HeY lUkA'. You say that as if everything's just peachy keen, huh?";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 8){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "I... don't follow?";
		}
		else if (primeInt == 9){
			ArtChar4.SetActive(false);
			ArtChar3.SetActive(true);
			Char1name.text = "Luka";
            Char1speech.text = "Oooh ahaha. Sorry sorry.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 10){
			Char1name.text = "Luka";
            Char1speech.text = "I haven't seen you in ages and it seems like you've been pretty distant.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 11){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "Oh.";
		}
		else if (primeInt == 12){
			Char1name.text = "Luka";
            Char1speech.text = "Like you've been trying to avoid me.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 13){
			Char1name.text = "Luka";
            Char1speech.text = "You've been ignoring my hellos.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 14){
			Char1name.text = "Luka";
            Char1speech.text = "My goodbyes.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 15){
			Char1name.text = "Luka";
            Char1speech.text = "Even rejecting my gifts.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 16){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "Oh, right... Uhm. Sorry about that.";
		}
		else if (primeInt == 17){
			ArtChar3.SetActive(false);
			ArtChar1.SetActive(true);
			Char1name.text = "Luka";
            Char1speech.text = "Haha... it's OKAY! It's okey.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 18){
			Char1name.text = "Luka";
            Char1speech.text = "It's okiiiiii.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 19){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "Cool, cool. Then I guess I'll see you lat-";
		}
		else if (primeInt == 20){
			Char1name.text = "Luka";
            Char1speech.text = "No.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 21){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "...no?";
		}
		else if (primeInt == 22){
			Char1name.text = "Luka";
            Char1speech.text = "Actually, now that I think about it...";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 23){
			Char1name.text = "Luka";
            Char1speech.text = "If I'm being really honest, it's not 'okay'.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 24){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "Luka...? You seeem pretty serious right now.";
		}
		else if (primeInt == 25){
			ArtChar1.SetActive(false);
			ArtChar4.SetActive(true);
			Char1name.text = "Luka";
            Char1speech.text = "I've done SO much for you. I've been by your side since the beginning, remember?";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 26){
			Char1name.text = "Luka";
            Char1speech.text = "I was there for you, I was ALWAYS there for you.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 27){
			Char1name.text = "Luka";
            Char1speech.text = "But.. when were you even there for me?";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 28){
			allowSpace = false;
			nextButton.SetActive(false);
			Choice1a.SetActive(true);
			Choice1b.SetActive(true);
		}
		else if (primeInt == 101){
			ArtChar4.SetActive(false);
			ArtChar3.SetActive(true);
			Char1name.text = "Luka";
            Char1speech.text = "Speechless, aren't you? That's what I thought.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 102){
			Char1name.text = "Luka";
            Char1speech.text = "You're just like the rest of them.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 103){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "Huh?";
			primeInt = 159;
		}
		else if (primeInt == 151){
			ArtChar4.SetActive(false);
			ArtChar1.SetActive(true);
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "Gee, let me think. There's plenty of times.";
		}
		else if (primeInt == 152){
			Char1name.text = "Luka";
            Char1speech.text = "Go on... ";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 153){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "Like ah... Mmm sorry. I'm blanking.";
		}
		else if (primeInt == 154){
			ArtChar3.SetActive(false);
			ArtChar4.SetActive(true);
			Char1name.text = "Luka";
            Char1speech.text = "...";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 155){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "O-oh! Remember when we first met? That's one ti-";
		}
		else if (primeInt == 156){
			ArtChar4.SetActive(true);
			ArtChar3.SetActive(false);
			Char1name.text = "Luka";
            Char1speech.text = "One time";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 157){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "Y-yeah, and I think there was that time when-";
		}
		else if (primeInt == 158){
			Char1name.text = "Luka";
            Char1speech.text = "ONE. TIME.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 159){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "Luka..?";
		}
		else if (primeInt == 160){
			ArtChar4.SetActive(false);
			ArtChar3.SetActive(true);
			Char1name.text = "Luka";
            Char1speech.text = "I remember that day all too well... I've never forgotten.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 161){
			Char1name.text = "Luka";
            Char1speech.text = "I was always around, no friends, no one happy to see me.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 162){
			Char1name.text = "Luka";
            Char1speech.text = "They all would shoo me away whenever I got near. They didn't want me.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 163){
			Char1name.text = "Luka";
            Char1speech.text = "...no one did.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 164){
			Char1name.text = "Luka";
            Char1speech.text = "There were times... Times where I thought I found where I belonged.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 165){
			Char1name.text = "Luka";
            Char1speech.text = "I thought I found my perfect person, my other half, my twin flame.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 166){
			Char1name.text = "Luka";
            Char1speech.text = "But no, it all ended the same. It always does.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 167){
			allowSpace = false;
			nextButton.SetActive(false);
			Choice1c.SetActive(true);
			Choice1d.SetActive(true);
		}
		else if (primeInt == 200){
			ArtChar3.SetActive(false);
			ArtChar4.SetActive(true);
			Char1name.text = "Luka";
            Char1speech.text = "SAY SOMETHING.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 201){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "I don't know what to say.";
		}
		else if (primeInt == 202){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "I don't know what you want me to say.";
		}
		else if (primeInt == 203){
			Char1name.text = "Luka";
            Char1speech.text = "You're just like them.";
            Char2name.text = "";
            Char2speech.text = "";
			primeInt = 251;
		}
		else if (primeInt == 251){
			ArtChar3.SetActive(true);
			Char1name.text = "Luka";
            Char1speech.text = "Which one? I've always been someone else's hand me down...";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 252){
			Char1name.text = "Luka";
            Char1speech.text = "First they butter me up with lies, making me think I was special to them.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 253){
			Char1name.text = "Luka";
            Char1speech.text = "They made me think they actually enjoyed my company...";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 254){
			Char1name.text = "Luka";
            Char1speech.text = "But they were only using me. They played me for a fool.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 255){
			Char1name.text = "Luka";
            Char1speech.text = "They treated me like I was some tool, a means to benefit from.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 256){
			Char1name.text = "Luka";
            Char1speech.text = "Someone with free homework to copy off of, someone who would always buy food for them.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 257){
			Char1name.text = "Luka";
            Char1speech.text = "But then I'd always find out, one way or another.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 258){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "Found out about what?";
		}
		else if (primeInt == 259){
			Char1name.text = "Luka";
            Char1speech.text = "Find out their real intentions. I'd overhear them talking about me, making fun of me behind my back.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 260){
			Char1name.text = "Luka";
            Char1speech.text = "Oh the things they'd say...";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 261){
			Char1name.text = "Luka";
            Char1speech.text = "'That annoying kid? Nah, I'm just using them. They can be pretty useful, sure.'";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 262){
			Char1name.text = "Luka";
            Char1speech.text = "'But that THING? A friend to me? I'd rank my dog higher than him.'";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 263){
			Char1name.text = "Luka";
            Char1speech.text = "'It's not even obedient to me like they are.'";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 264){
			ArtChar3.SetActive(false);
			ArtChar4.SetActive(true);
			Char1name.text = "Luka";
            Char1speech.text = "That broke me... Oh how that hurt me.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 265){
			Char1name.text = "Luka";
            Char1speech.text = "How I longed to see them pay... to see them all die.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 266){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "You... Luka, you didn't...?";
		}
		else if (primeInt == 267){
			ArtChar4.SetActive(false);
			ArtChar1.SetActive(true);
			Char1name.text = "Luka";
            Char1speech.text = "Oh c'mon bestie, you really think I'd do that?";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 268){
			Char1name.text = "Luka";
            Char1speech.text = "You think I'm that kind of monster? You really think so?";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 269){
			allowSpace = false;
			nextButton.SetActive(false);
			Choice1e.SetActive(true);
			Choice1f.SetActive(true);
		}
		else if (primeInt == 301){
			ArtChar1.SetActive(false);
			ArtChar3.SetActive(true);
			Char1name.text = "Luka";
            Char1speech.text = "Not even you trust me. My supposed best friend.";
            Char2name.text = "";
            Char2speech.text = "";
			primeInt = 353;
		}
		else if (primeInt == 351){
			    Char1name.text = "Luka";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 352){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "...";
		}
		else if (primeInt == 353){
			ArtChar1.SetActive(false);
			ArtChar3.SetActive(true);
			Char1name.text = "Luka";
            Char1speech.text = "Liar.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 354){
			ArtChar3.SetActive(false);
			ArtChar1.SetActive(true);
			Char1name.text = "Luka";
            Char1speech.text = "That day I met you, I was almost at my breaking point had you not come along.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 355){
			ArtChar1.SetActive(false);
			ArtChar2.SetActive(true);
			Char1name.text = "Luka";
            Char1speech.text = "You were new, you didn't know anybody. Yet you came to me...";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 356){
			Char1name.text = "Luka";
            Char1speech.text = "You talked to me... You made me feel...";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 357){
			Char1name.text = "Luka";
            Char1speech.text = "You made me feel like a person with feelings. You made me feel... Human.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 358){
			Char1name.text = "Luka";
            Char1speech.text = "At last, someone... someone who actually likes having me around.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 359){
			Char1name.text = "Luka";
            Char1speech.text = "Someone I can really call a friend. My bestest friend...";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 360){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "Luka, I had no idea you lived a life like that.";
		}
		else if (primeInt == 361){
			Char1name.text = "Luka";
            Char1speech.text = "I don't expect you to know... it's alright.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 362){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "Hey... Luka, I-";
		}
		else if (primeInt == 363){
			ArtChar2.SetActive(false);
			ArtChar1.SetActive(true);
			Char1name.text = "Luka";
            Char1speech.text = "I'm sorry for getting upset.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 364){
			Char1name.text = "Luka";
            Char1speech.text = "I know I'm annoying, clingy, overly excited...";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 365){
			Char1name.text = "Luka";
            Char1speech.text = "I just... I just wanted to be with you. The person I cared about most.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 366){
			Char1name.text = "Luka";
            Char1speech.text = "I'll try not to be a pest...";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 367){
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "Hey! Luka, wait!";
		}
		else if (primeInt == 368){
			ArtChar1.SetActive(false);
			ArtChar4.SetActive(true);
			Char1name.text = "Luka";
            Char1speech.text = "Hehe... And here I thought maybe you were different. Shame on me for thinking so.";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 369){
			Char1name.text = "Luka";
            Char1speech.text = "You really are just like everyone else! Well, don't worry! I won't bother you anymore!";
            Char2name.text = "";
            Char2speech.text = "";
		}
		else if (primeInt == 370){
			ArtChar4.SetActive(false);
			Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "Before you could reach out, Luka runs out of sight.";
		}
		else if (primeInt == 371){
			allowSpace = false;
			nextButton.SetActive(false);
			Choice1g.SetActive(true);
			Choice1h.SetActive(true);
		}
		else if (primeInt == 401){
			NextScene1Button.SetActive(true);
		}
		else if (primeInt == 451){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Luka! Wait!";
		}
		else if (primeInt == 452){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Luka";
			Char2speech.text = "...";
		}
		else if (primeInt == 453){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Hey! Look. I'm sorry. I'm sorry for never being there for you. It's not fair to you after everything you've done for me.";
		}
		else if (primeInt == 454){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "I know I'm not the best friend you could have. Far from it actually. But could you give me another chance?";
		}
		else if (primeInt == 455){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Will you go to Homecoming with me? So I can prove how sorry I am?";
		}
		else if (primeInt == 456){
			ArtChar3.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Luka";
			Char2speech.text = "Are you... are you serious? Do you really mean that?";
		}
		else if (primeInt == 457){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Luka";
			Char2speech.text = "You're not just saying that are you?";
		}
		else if (primeInt == 458){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "I swear and I promise you that it won't be like this anymore. Just let me prove it to you.";
		}
		else if (primeInt == 459){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Luka";
			Char2speech.text = "One chance.";
		}
		else if (primeInt == 460){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Huh?";
		}
		else if (primeInt == 461){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Luka";
			Char2speech.text = "You have one more chance.";
		}
		else if (primeInt == 462){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = playerName;
			Char2speech.text = "Great! You won't regret it. I'll see you Friday?";
		}
		else if (primeInt == 463){
			ArtChar3.SetActive(false);
			ArtChar1.SetActive(true);
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Luka";
			Char2speech.text = "... See you Friday.";
		}
		else if (primeInt == 464){
			NextScene2Button.SetActive(true);
		}
		
   }
   public void Choice1aFunct(){
	   Char1name.text = "";
	   Char1speech.text = "";
	   Char2name.text = playerName;
	   Char2speech.text = "...";
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
        Char2speech.text = "Oh, Luka... um...";
		Choice1a.SetActive(false);
		Choice1b.SetActive(false);
		allowSpace = true;
		nextButton.SetActive(true);
		primeInt = 151;
   }
   public void Choice1cFunct(){
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = playerName;
        Char2speech.text = "...";
		Choice1c.SetActive(false);
		Choice1d.SetActive(false);
		allowSpace = true;
		nextButton.SetActive(true);
		primeInt = 200;
   }
   public void Choice1dFunct(){
	   Char1name.text = "";
       Char1speech.text = "";
       Char2name.text = playerName;
       Char2speech.text = "Luka... who were you with before you met me?";
	   Choice1c.SetActive(false);
	   Choice1d.SetActive(false);
	   allowSpace = true;
	   nextButton.SetActive(true);
	   primeInt = 250;
   }
   public void Choice1eFunct(){
		Char1name.text = "";
		Char1speech.text = "";
        Char2name.text = playerName;
        Char2speech.text = "...";
		Choice1e.SetActive(false);
		Choice1f.SetActive(false);
		allowSpace = true;
		nextButton.SetActive(true);
		primeInt = 300;
   }
   public void Choice1fFunct(){
		Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = playerName;
        Char2speech.text = "O-oh, of course not!";
		Choice1e.SetActive(false);
		Choice1f.SetActive(false);
		allowSpace = true;
		nextButton.SetActive(true);
		primeInt = 350;
   }
   public void Choice1gFunct(){
	   Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "I should probably give them some space...";
			primeInt = 400;
			allowSpace = true;
			nextButton.SetActive(true);
			Choice1g.SetActive(false);
			Choice1h.SetActive(false);
   }
   public void Choice1hFunct(){
	   Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = playerName;
            Char2speech.text = "I have to fix this.";
			primeInt = 450;
			allowSpace = true;
			nextButton.SetActive(true);
			Choice1g.SetActive(false);
			Choice1h.SetActive(false);
   }
   public void SceneChange1(){
	   SceneManager.LoadScene("End_LoseLuka");
   }   
   public void SceneChange2(){
	   SceneManager.LoadScene("Scene7C");
   }
}