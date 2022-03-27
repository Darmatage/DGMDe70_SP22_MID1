using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene6 : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject BlueChiefArt;
        public GameObject JasonFrown;
        public GameObject JasonSmile;
        public GameObject JasonNormal;
        public GameObject ArtBG1;
        public GameObject Choice7;
        public GameObject NextScene7Button;
        public GameObject NextButton;
        // public GameHandler gameHandler;
        // public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        BlueChiefArt.SetActive(false);
        JasonFrown.SetActive(false);
        JasonSmile.SetActive(false);
        JasonNormal.SetActive(false);
        ArtBG1.SetActive(true);
        Choice7.SetActive(false);
        NextScene7Button.SetActive(false);
        NextButton.SetActive(true);
		GameObject.Find("Hierarchy_Hall").GetComponent<AudioSource>().Play();
   }

void Update(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       talking();
                       // AudioSource.Play();
                }
        }
   }

//Story Units:
public void talking(){         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1){
        }
        else if (primeInt == 2){
                DialogueDisplay.SetActive(true);
                JasonNormal.SetActive(true);
                BlueChiefArt.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "(Emerging from the cave, I am welcomed by the Game Object natives.)";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Blue Chief";
                Char2speech.text = "The skies have cleared! The seas are cleansed!";
                Char3name.text = "";
                Char3speech.text = "";
				GameObject.Find("Native_Startled").GetComponent<AudioSource>().Play();

                //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Blue Chief";
                Char2speech.text = "It is all thanks to you, Brave Champion!";
                Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
				GameObject.Find("Native_Talk").GetComponent<AudioSource>().Play();
        }
        else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Blue Chief";
                Char2speech.text = "Come! We must celebrate!";
                Char3name.text = "";
                Char3speech.text = "";
				GameObject.Find("Native_Talk").GetComponent<AudioSource>().Play();
        }
        else if (primeInt == 6){
                Char1name.text = "Jason";
                Char1speech.text = "(A grand celebration ensues, and a statue for Cubey is erected.)";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 7){
                Char1name.text = "Jason";
                Char1speech.text = "(He shall be immortalized in this realm...)";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 8){
                 Char1name.text = "Jason";
                 Char1speech.text = "(I dance with the natives, I eat strange pixelated foods, and I tour the wondrous lands of Unity...)";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";
         }
          else if (primeInt == 9){
                  Char1name.text = "Jason";
                  Char1speech.text = "(But I can't bring myself to fully enjoy the festivities...)";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
          }
          else if (primeInt == 10){
                   Char1name.text = "Jason";
                   Char1speech.text = "I... I can't stay here. I need to go back.";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
				   GameObject.Find("JasonHmm1").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 11){
                  Char1name.text = "Jason";
                  Char1speech.text = "(The natives are very understanding, and they fulfill my wishes.)";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
          }
          else if (primeInt == 12){
                   Char1name.text = "Jason";
                   Char1speech.text = "(The elder collects some freshly harvested papyrus and writes up a scroll of teleportation.)";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
          }
          else if (primeInt == 13){
                   Char1name.text = "Jason";
                   Char1speech.text = "(And in no time, I find myself being transported back to reality.)";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
                   NextButton.SetActive(false);
                   allowSpace = false;
                   NextScene7Button.SetActive(true);
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
                   NextScene7Button.SetActive(true);
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
                   NextScene7Button.SetActive(true);
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
                Choice7.SetActive(false);
                NextButton.SetActive(true);
                allowSpace = true;
        }

        public void Choice7Funct(){
                JasonFrown.SetActive(false);
                JasonSmile.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "It seems like you're mistaken Cubey...";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 199;
                Choice7.SetActive(false);
                NextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange3c(){
               SceneManager.LoadScene("Scene3c");
        }
        public void SceneChange7(){
               SceneManager.LoadScene("Scene7");
        }
}
