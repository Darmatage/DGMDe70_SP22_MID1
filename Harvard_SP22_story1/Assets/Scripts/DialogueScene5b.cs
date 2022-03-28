using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene5b : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject CubeyArt;
               public GameObject CubeySphere;
               public GameObject CubeyDead;
        public GameObject ErrorMonsterArt;
        public GameObject ErrorMonsterSideArt;
        // public GameObject ErrorMonsterFadeArt;
        public GameObject JasonFrown;
        public GameObject JasonSmile;
        public GameObject JasonNormal;
        public GameObject ArtBG1;
		public GameObject ArtBG2;
        public GameObject ConsoleCaveFadeBG;
		public GameObject ConsoleCaveGreenFadeBG;
        public GameObject Choice6;
        public GameObject NextScene6Button;
        public GameObject NextButton;
        // public GameHandler gameHandler;
        // public AudioSource audioSource;
        private bool allowSpace = true;
		private bool skip = false;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ErrorMonsterArt.SetActive(false);
        ErrorMonsterSideArt.SetActive(false);
        // ErrorMonsterFadeArt.SetActive(false);
        CubeyArt.SetActive(false);
             CubeySphere.SetActive(false);
             CubeyDead.SetActive(false);
        JasonFrown.SetActive(false);
        JasonSmile.SetActive(false);
        JasonNormal.SetActive(false);
        ArtBG1.SetActive(true);
		ArtBG2.SetActive(false);
        ConsoleCaveFadeBG.SetActive(false);
		ConsoleCaveGreenFadeBG.SetActive(false);
        Choice6.SetActive(false);
        NextScene6Button.SetActive(false);
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
                JasonSmile.SetActive(true);
                CubeyArt.SetActive(true);
                ErrorMonsterSideArt.SetActive(false);
                Char1name.text = "Jason";
                Char1speech.text = "(I take Cubey's weaponized body into my own hands, and I can feel him glowing with excitement.)";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
				GameObject.Find("JasonWow2").GetComponent<AudioSource>().Play();
        }
        else if (primeInt == 3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Cubey";
                Char2speech.text = "It seems like... Cubey is finally assisting you!";
                Char3name.text = "";
                Char3speech.text = "";
				GameObject.Find("Cuby_Happy").GetComponent<AudioSource>().Play();

                //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Cubey";
                Char2speech.text = "Cubey... Cubey is happy!";
                Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
				GameObject.Find("Cuby_Happy").GetComponent<AudioSource>().Play();
        }
        else if (primeInt == 5){
                Char1name.text = "Jason";
                Char1speech.text = "This is an absolutely cheesy situation that we've found ourselves in...";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
				GameObject.Find("JasonHmm1").GetComponent<AudioSource>().Play();
        }
        else if (primeInt == 6){
                Char1name.text = "Jason";
                Char1speech.text = "But you know what Cubey...";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 7){
                Char1name.text = "Jason";
                Char1speech.text = "you've been nothing but a wholesome source of assistance this whole time,";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
				GameObject.Find("JasonHmm3").GetComponent<AudioSource>().Play();
        }
        else if (primeInt == 8){
                 Char1name.text = "Jason";
                 Char1speech.text = "and only now do I really appreciate that, cheese-be-damned.";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";
         }
          else if (primeInt == 9){
                  Char1name.text = "Jason";
                  Char1speech.text = "Let's do this, together!";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
				  GameObject.Find("JasonHmm2").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 10){
                   ErrorMonsterSideArt.SetActive(true);
                   Char1name.text = "Jason";
                   Char1speech.text = "(We charge deep into the cave, and we find the red creature cowering in fear.)";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
				   GameObject.Find("Error_Talk").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 11){
                  Char1name.text = "Jason";
                  Char1speech.text = "(Ha! Who knew the power of friendship actually works against Unity errors!)";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
          }
          else if (primeInt == 12){
                  ArtBG1.SetActive(false);
                  ConsoleCaveFadeBG.SetActive(true);
                  CubeyArt.SetActive(false);
                        CubeySphere.SetActive(true);
                   Char1name.text = "Jason";
                   Char1speech.text = "Hya!";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
				   GameObject.Find("JasonHurt2").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 13){
                   Char1name.text = "Jason";
                   Char1speech.text = "(I plunge Cubey's spear form deep into the eyeball of the creature.)";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
				   GameObject.Find("Error_Talk").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 14){
                   Char1name.text = "Jason";
                   Char1speech.text = "(And it lets out a fleshy death sound effect.)";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
          }
          else if (primeInt == 15){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "ERROR";
                   Char3speech.text = "ERROR ERROR... ER...ROR...";
				   GameObject.Find("Error_Hurt").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 16){
                   // ErrorMonsterFadeArt.SetActive(true);
                   ErrorMonsterSideArt.SetActive(false);
				        ConsoleCaveFadeBG.SetActive(false);
					ArtBG2.SetActive(true);
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
          }
          else if (primeInt == 17){
                   Char1name.text = "Jason";
                   Char1speech.text = "We did it, Cubey! We did it!";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
				   GameObject.Find("JasonHmm3").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 18){
                   JasonSmile.SetActive(false);
                   JasonNormal.SetActive(true);
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Cubey";
                   Char2speech.text = "...";
                   Char3name.text = "";
                   Char3speech.text = "";
				   GameObject.Find("Cuby_Startled").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 19){
                   JasonNormal.SetActive(false);
                   JasonFrown.SetActive(true);
                   Char1name.text = "Jason";
                   Char1speech.text = "Cubey? Cubey!?";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
				   GameObject.Find("JasonNo2").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 20){
                     CubeySphere.SetActive(false);
                     CubeyDead.SetActive(true);
                   Char1name.text = "Jason";
                   Char1speech.text = "(Upon closer inspection, Cubey's frail little body has been devastated by the battle...)";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
          }
          else if (primeInt == 21){
                   Char1name.text = "Jason";
                   Char1speech.text = "Oh no, hang in there buddy. I'll get you to a docto-";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
				   GameObject.Find("JasonHurt2").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 22){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Cubey";
                   Char2speech.text = "No, Jason... No...";
                   Char3name.text = "";
                   Char3speech.text = "";
				   GameObject.Find("Cuby_Sad").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 23){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Cubey";
                   Char2speech.text = "It seems like, this is my purpose...";
                   Char3name.text = "";
                   Char3speech.text = "";
				   GameObject.Find("Cuby_Happy").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 24){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Cubey";
                   Char2speech.text = "This is how... I would have liked it to end...";
                   Char3name.text = "";
                   Char3speech.text = "";
				   GameObject.Find("Cuby_Sad").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 25){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Cubey";
                   Char2speech.text = "Was... was I of assistance today?";
                   Char3name.text = "";
                   Char3speech.text = "";
				   GameObject.Find("Cuby_Sad").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 26){
                   Char1name.text = "Jason";
                   Char1speech.text = "Yes... yes, you were, Cubey.";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
          }
          else if (primeInt == 27){
                   ArtBG1.SetActive(false);
                   ConsoleCaveGreenFadeBG.SetActive(true);
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
                   NextButton.SetActive(false);
                   allowSpace = false;
				   skip = false;
				   CancelInvoke();
                   NextScene6Button.SetActive(true);
          }
          // Choice 3c
          else if (primeInt == 100){
                   Char1name.text = "Jason";
                   Char1speech.text = "(And who knows, what if you die in the game, you die in real life!)";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
          }
          else if (primeInt == 101){
                   Char1name.text = "Jason";
                   Char1speech.text = "I can't believe I'm saying this... but thank you Cubey...";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
				   GameObject.Find("JasonHmm3").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 102){
                   Char1name.text = "Jason";
                   Char1speech.text = "I'll never forget you!";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
          }
          else if (primeInt == 103){
                   Char1name.text = "Jason";
                   Char1speech.text = "(I dash out of the cave, and I don't look back...)";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
                   NextButton.SetActive(false);
                   allowSpace = false;
				   skip = false;
				   CancelInvoke();
                   NextScene6Button.SetActive(true);
          }

          // Choice 6
          else if (primeInt == 200){
                   Char1name.text = "Jason";
                   Char1speech.text = "I would like to do this together!";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
                   NextButton.SetActive(false);
                   allowSpace = false;
				   skip = false;
				   CancelInvoke();
                   NextScene6Button.SetActive(true);
				   GameObject.Find("JasonHmm1").GetComponent<AudioSource>().Play();
          }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice3cFunct(){
                Char1name.text = "Jason";
                Char1speech.text = "(This nightmare is taking a turn for the worse...)";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 99;
                Choice6.SetActive(false);
                NextButton.SetActive(true);
                allowSpace = true;
        }

        public void Choice6Funct(){
                JasonFrown.SetActive(false);
                JasonSmile.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "It seems like you're mistaken Cubey...";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 199;
                Choice6.SetActive(false);
                NextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange3c(){
               SceneManager.LoadScene("Scene3c");
        }
        public void SceneChange6(){
               SceneManager.LoadScene("Scene6");
        }
}
