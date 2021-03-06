using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene4b : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public GameObject DialogueDisplay;
        public GameObject ErrorMonsterArtTransparent;
        public GameObject ErrorMonsterArt;
        public GameObject JasonFrown;
        public GameObject JasonSmile;
        public GameObject JasonNormal;
        public GameObject ArtBG1;
        public GameObject FadingBG;
        public GameObject Choice5a;
        public GameObject NextScene5aButton;
        public GameObject NextButton;
        // public GameHandler gameHandler;
        // public AudioSource audioSource;
        private bool allowSpace = true;
		private bool skip = false;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ErrorMonsterArt.SetActive(false);
        ErrorMonsterArtTransparent.SetActive(false);
        JasonFrown.SetActive(false);
        JasonSmile.SetActive(false);
        JasonNormal.SetActive(false);
        ArtBG1.SetActive(true);
        FadingBG.SetActive(false);
        Choice5a.SetActive(false);
        NextScene5aButton.SetActive(false);
        NextButton.SetActive(true);
		GameObject.Find("Console_Cave").GetComponent<AudioSource>().Play();
   }

void Update(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       talking();
                       // AudioSource.Play();
                }
        }
   }

public void skipmode(){
	if (skip == true) {
		CancelInvoke();
		skip = false;
	}
	else {
		skip = true;
		InvokeRepeating("talking", 0, 0.1F);
	}
}

//Story Units:
public void talking(){         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1){
        }
        else if (primeInt == 2){
                DialogueDisplay.SetActive(true);
                JasonFrown.SetActive(true);
                ErrorMonsterArtTransparent.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "(I cautiously sneak deeper into the depths of the error's den...)";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 3){
                Char1name.text = "Jason";
                Char1speech.text = "(the dropping red text is good camoflauge for the error, and its eerie red glow becomes stronger the deeper in I go.)";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4){
                Char1name.text = "Jason";
                Char1speech.text = "(I pick up a long stalagmite to use as a weapon,)";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 5){
                Char1name.text = "Jason";
                Char1speech.text = "(and begin approaching the source of the red light.)";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6){
                ErrorMonsterArtTransparent.SetActive(false);
                ErrorMonsterArt.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "(There, 10 meters in the cave, is my prey.)";
                Char2name.text = "";
                Char2speech.text = "";
				GameObject.Find("Error_Talk").GetComponent<AudioSource>().Play();
        }
        else if (primeInt == 7){
                Char1name.text = "Jason";
                Char1speech.text = "(It doesn't seem to notice me yet.)";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 8){
                Char1name.text = "Jason";
                Char1speech.text = "(It has a large bulbous head with four... no, five limbs holding it up...)";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 9){
                 Char1name.text = "Jason";
                 Char1speech.text = "(A strange creature indeed...)";
                 Char2name.text = "";
                 Char2speech.text = "";
         }
         else if (primeInt == 10){
                  Char1name.text = "Jason";
                  Char1speech.text = "(Not that it matters what it looks like.)";
                  Char2name.text = "";
                  Char2speech.text = "";
          }
          else if (primeInt == 11){
                  Char1name.text = "Jason";
                  Char1speech.text = "(The problem is its SIZE.)";
                  Char2name.text = "";
                  Char2speech.text = "";
          }
          else if (primeInt == 12){
                   Char1name.text = "Jason";
                   Char1speech.text = "(It towers over me like an impossible boss from a Souls-like game...)";
                   Char2name.text = "";
                   Char2speech.text = "";
          }
          else if (primeInt == 13){
                  Char1name.text = "Jason";
                  Char1speech.text = "But I've got the jump on it...";
                  Char2name.text = "";
                  Char2speech.text = "";
          }
          else if (primeInt == 14){
                   Char1name.text = "Jason";
                   Char1speech.text = "I can do this!";
                   Char2name.text = "";
                   Char2speech.text = "";
          }
          else if (primeInt == 15){
                   Char1name.text = "Jason";
                   Char1speech.text = "(With stalagmite in hand and a wealth of action-rpg knowledge, I sneak-attack the red creature!)";
                   Char2name.text = "";
                   Char2speech.text = "";
				   GameObject.Find("Error_Talk").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 16){
                   Char1name.text = "Jason";
                   Char1speech.text = "Ha! Critical Hit!";
                   Char2name.text = "";
                   Char2speech.text = "";
				   GameObject.Find("Error_Talk").GetComponent<AudioSource>().Play();
				   GameObject.Find("JasonHurt2").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 17){
                   Char1name.text = "Jason";
                   Char1speech.text = "(To my surprise, the back of its head shoots open, revealing a huge eyeball.)";
                   Char2name.text = "";
                   Char2speech.text = "";
				   GameObject.Find("Error_Talk").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 18){
                   Char1name.text = "Jason";
                   Char1speech.text = "HA! Take that!";
                   Char2name.text = "";
                   Char2speech.text = "";
				   GameObject.Find("Error_Talk").GetComponent<AudioSource>().Play();
				   GameObject.Find("JasonHurt2").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 19){
                   Char1name.text = "Jason";
                   Char1speech.text = "(Despite its size, it manages to weave around my attacks effortlessly.)";
                   Char2name.text = "";
                   Char2speech.text = "";
				   GameObject.Find("Error_Talk").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 20){
                   Char1name.text = "Jason";
                   Char1speech.text = "(This really is a boss fight!)";
                   Char2name.text = "";
                   Char2speech.text = "";
          }
          else if (primeInt == 21){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "ERROR";
                   Char2speech.text = "ALL COMPILER ERRORS HAVE TO BE FIXED BEFORE YOU CAN ENTER PLAY MODE";
				   GameObject.Find("Error_Talk").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 22){
                   Char1name.text = "Jason";
                   Char1speech.text = "(Two tentacles lash out at me in a flurry of movement.)";
                   Char2name.text = "";
                   Char2speech.text = "";
				   GameObject.Find("Error_Talk").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 23){
                   Char1name.text = "Jason";
                   Char1speech.text = "Ugh?!";
                   Char2name.text = "";
                   Char2speech.text = "";
				   GameObject.Find("Error_Talk").GetComponent<AudioSource>().Play();
				   GameObject.Find("JasonHurt2").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 24){
                   Char1name.text = "Jason";
                   Char1speech.text = "(I jump out of the way, but it manages to clip my leg...)";
                   Char2name.text = "";
                   Char2speech.text = "";
          }
          else if (primeInt == 25){
                   Char1name.text = "Jason";
                   Char1speech.text = "(I'm not bleeding, but my leg is now missing a big chunk of its pixels...)";
                   Char2name.text = "";
                   Char2speech.text = "";
          }
          else if (primeInt == 26){
                   Char1name.text = "Jason";
                   Char1speech.text = "Ah! Oh shoot...";
                   Char2name.text = "";
                   Char2speech.text = "";
				   GameObject.Find("Error_Talk").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 27){
                   Char1name.text = "Jason";
                   Char1speech.text = "(It's painful when I try to move it...)";
                   Char2name.text = "";
                   Char2speech.text = "";
          }
          else if (primeInt == 28){
                   Char1name.text = "Jason";
                   Char1speech.text = "(Oh no...)";
                   Char2name.text = "";
                   Char2speech.text = "";
				   GameObject.Find("JasonNo2").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 29){
                   Char1name.text = "Jason";
                   Char1speech.text = "(This is... very bad...)";
                   Char2name.text = "";
                   Char2speech.text = "";
          }
          else if (primeInt == 30){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "ERROR";
                   Char2speech.text = "ASSETS/SCRIPTS/ADVENTURESWITHCUBEY.CS(42:69)/BCE2022/MISSING/GAMEOBJECT/CUBEY";
				   GameObject.Find("Error_Talk").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 31){
                   Char1name.text = "Jason";
                   Char1speech.text = "(The monster pulls back and raises all 5 of its limbs.)";
                   Char2name.text = "";
                   Char2speech.text = "";
				   GameObject.Find("Error_Talk").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 32){
                   Char1name.text = "Jason";
                   Char1speech.text = "(Almost as if charging up someth-)";
                   Char2name.text = "";
                   Char2speech.text = "";
          }
          else if (primeInt == 33){
                   Char1name.text = "Jason";
                   Char1speech.text = "Oh no... no... wai-!";
                   Char2name.text = "";
                   Char2speech.text = "";
          }
          else if (primeInt == 34){
                   Char1name.text = "Jason";
                   Char1speech.text = "(A torrent of tentacles engulf me, followed by the disintegration of all of my pixels...)";
                   Char2name.text = "";
                   Char2speech.text = "";
				   GameObject.Find("Error_Talk").GetComponent<AudioSource>().Play();
				   GameObject.Find("JasonHurt2").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 35){
                   ArtBG1.SetActive(false);
                   ErrorMonsterArt.SetActive(false);
                   FadingBG.SetActive(true);
                   Char1name.text = "Jason";
                   Char1speech.text = "...";
                   Char2name.text = "";
                   Char2speech.text = "";
				   GameObject.Find("Error_Talk").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 36){
                   Char1name.text = "Jason";
                   Char1speech.text = "(And everything goes black...)";
                   Char2name.text = "";
                   Char2speech.text = "";
                   NextButton.SetActive(false);
                   allowSpace = false;
				   skip = false;
				   CancelInvoke();
                   NextScene5aButton.SetActive(true);
          }
          // Choice 5a
          else if (primeInt == 100){
                   Char1name.text = "Jason";
                   Char1speech.text = "(Time to make a run for it!)";
                   Char2name.text = "";
                   Char2speech.text = "";
                   NextButton.SetActive(false);
                   allowSpace = false;
				   skip = false;
				   CancelInvoke();
                   NextScene5aButton.SetActive(true);
          }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice5aFunct(){
                Char1name.text = "Jason";
                Char1speech.text = "You know what... Maybe I DO need Cubey's assistance.";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 99;
                Choice5a.SetActive(false);
                NextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange5a(){
               SceneManager.LoadScene("Scene5a");
        }
}
