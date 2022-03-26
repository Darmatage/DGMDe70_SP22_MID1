using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene4a : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public GameObject DialogueDisplay;
        public GameObject CubeyArt;
        public GameObject CubeyTransform;
        public GameObject ErrorMonsterArt;
        public GameObject ErrorMonsterSideArt;
        public GameObject JasonFrown;
        public GameObject JasonSmile;
        public GameObject JasonNormal;
        public GameObject ArtBG1;
        public GameObject Choice3c;
        public GameObject Choice5b;
        public GameObject NextScene3cButton;
        public GameObject NextScene5bButton;
        public GameObject NextButton;
        // public GameHandler gameHandler;
        // public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ErrorMonsterArt.SetActive(false);
        ErrorMonsterSideArt.SetActive(false);
        CubeyArt.SetActive(false);
        CubeyTransform.SetActive(false);
        JasonFrown.SetActive(false);
        JasonSmile.SetActive(false);
        JasonNormal.SetActive(false);
        ArtBG1.SetActive(true);
        Choice3c.SetActive(false);
        Choice5b.SetActive(false);
        NextScene3cButton.SetActive(false);
        NextScene5bButton.SetActive(false);
        NextButton.SetActive(true);
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
                JasonFrown.SetActive(true);
                ErrorMonsterArt.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "(I slowly back away from the creature... but something sharp abruptly bumps into my back.)";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 3){
                ErrorMonsterArt.SetActive(false);
                CubeyTransform.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "?!?!";
                Char2name.text = "";
                Char2speech.text = "";

                //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4){
                CubeyTransform.SetActive(false);
                CubeyArt.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Cubey";
                Char2speech.text = "It seems like I finally found you Jason! Would you like some assistance today?";
                //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 5){
                Char1name.text = "Jason";
                Char1speech.text = "Wha-? Shhh quiet Cubey! You're gonna alert the-";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 6){
                ErrorMonsterSideArt.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "(A mind curdling scream echoes through the cavern.)";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 7){
                Char1name.text = "Jason";
                Char1speech.text = "(It sounded like a frenzied Tasmanian devil attacking a broken Windows XP computer...)";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 8){
                 Char1name.text = "Jason";
                 Char1speech.text = "(Or vice versa.)";
                 Char2name.text = "";
                 Char2speech.text = "";
         }
          else if (primeInt == 9){
                  Char1name.text = "Jason";
                  Char1speech.text = "Oh no oh no oh no, this is not what I signed up for!";
                  Char2name.text = "";
                  Char2speech.text = "";
          }
          else if (primeInt == 10){
                   Char1name.text = "Jason";
                   Char1speech.text = "(The red thing approaches us and shoots open its eyelids, revealing a huge unity error sign.)";
                   Char2name.text = "";
                   Char2speech.text = "";
          }
          else if (primeInt == 11){
                  Char1name.text = "Jason";
                  Char1speech.text = "(It unfurls and brandishes five long, pixelated tentacles.)";
                  Char2name.text = "";
                  Char2speech.text = "";
          }
          else if (primeInt == 12){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Cubey";
                   Char2speech.text = "Oh, it seems like we're in danger! Would you like me to assist you?";
          }
          else if (primeInt == 13){
                   Char1name.text = "Jason";
                   Char1speech.text = "No, we gotta run, Cubey, what could we possibly do against THAT thing?!";
                   Char2name.text = "";
                   Char2speech.text = "";
          }
          else if (primeInt == 14){
                   Char1name.text = "Jason";
                   Char1speech.text = "(The error creature advances towards us with terrifying speed, and before I know it, it's preparing to pounce on us.)";
                   Char2name.text = "";
                   Char2speech.text = "";
          }
          else if (primeInt == 15){
                   Char1name.text = "Jason";
                   Char1speech.text = "...!";
                   Char2name.text = "";
                   Char2speech.text = "";
          }
          else if (primeInt == 16){
                   Char1name.text = "Jason";
                   Char1speech.text = "(The sharp sound of metal being twisted is followed by a fleshy howl)";
                   Char2name.text = "";
                   Char2speech.text = "";
          }
          else if (primeInt == 17){
                   Char1name.text = "Jason";
                   Char1speech.text = "(I open my eyes, and to my surprise...)";
                   Char2name.text = "";
                   Char2speech.text = "";
          }
          else if (primeInt == 18){
                   Char1name.text = "Jason";
                   Char1speech.text = "(Cubey has transformed into a sharp spear and has plunged himself into the monster!)";
                   Char2name.text = "";
                   Char2speech.text = "";
          }
          else if (primeInt == 19){
                   Char1name.text = "Jason";
                   Char1speech.text = "Cubey?!";
                   Char2name.text = "";
                   Char2speech.text = "";
          }
          else if (primeInt == 20){
                   Char1name.text = "Jason";
                   Char1speech.text = "(The monster violently pulls cubey out of itself and retreats into the darkness.)";
                   Char2name.text = "";
                   Char2speech.text = "";
          }
          else if (primeInt == 21){
                   Char1name.text = "Jason";
                   Char1speech.text = "Cubey! Are you okay Cubey!?";
                   Char2name.text = "";
                   Char2speech.text = "";
          }
          else if (primeInt == 22){
                   Char1name.text = "Jason";
                   Char1speech.text = "(I pick Cubey up in my arms, and he is obviously missing a few pixels here and there.)";
                   Char2name.text = "";
                   Char2speech.text = "";
          }
          else if (primeInt == 23){
                   Char1name.text = "Jason";
                   Char1speech.text = "(Is he really willing to go to such lengths, just to give me assistance?!)";
                   Char2name.text = "";
                   Char2speech.text = "";
          }
          else if (primeInt == 24){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Cubey";
                   Char2speech.text = "*cough* *cough* It seems like... I've assisted you... today... *cough*";
          }
          else if (primeInt == 25){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Cubey";
                   Char2speech.text = "It seems like... the error... will return soon...";
          }
          else if (primeInt == 26){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Cubey";
                   Char2speech.text = "Would you... please... escape... and go without me...";
          }
          else if (primeInt == 27){
                   Char1name.text = "Jason";
                   Char1speech.text = "What should I do?";
                   Char2name.text = "";
                   Char2speech.text = "";
                   NextButton.SetActive(false);
                   allowSpace = false;
                   Choice3c.SetActive(true);
                   Choice5b.SetActive(true);
          }
          // Choice 3c
          else if (primeInt == 100){
                   Char1name.text = "Jason";
                   Char1speech.text = "(And who knows, what if you die in the game, you die in real life!)";
                   Char2name.text = "";
                   Char2speech.text = "";
          }
          else if (primeInt == 101){
                   Char1name.text = "Jason";
                   Char1speech.text = "I can't believe I'm saying this... but thank you Cubey...";
                   Char2name.text = "";
                   Char2speech.text = "";
          }
          else if (primeInt == 102){
                   Char1name.text = "Jason";
                   Char1speech.text = "I'll never forget you!";
                   Char2name.text = "";
                   Char2speech.text = "";
          }
          else if (primeInt == 103){
                   Char1name.text = "Jason";
                   Char1speech.text = "(I dash out of the cave, and I don't look back...)";
                   Char2name.text = "";
                   Char2speech.text = "";
                   NextButton.SetActive(false);
                   allowSpace = false;
                   NextScene5bButton.SetActive(true);
          }

          // Choice 5b
          else if (primeInt == 200){
                   Char1name.text = "Jason";
                   Char1speech.text = "I would like to do this together!";
                   Char2name.text = "";
                   Char2speech.text = "";
                   NextButton.SetActive(false);
                   allowSpace = false;
                   NextScene5bButton.SetActive(true);
          }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice3cFunct(){
                Char1name.text = "Jason";
                Char1speech.text = "(This nightmare is taking a turn for the worse...)";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 99;
                Choice3c.SetActive(false);
                Choice5b.SetActive(false);
                NextButton.SetActive(true);
                allowSpace = true;
        }

        public void Choice5bFunct(){
                JasonFrown.SetActive(false);
                JasonSmile.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "It seems like you're mistaken Cubey...";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 199;
                Choice3c.SetActive(false);
                Choice5b.SetActive(false);
                NextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange3c(){
               SceneManager.LoadScene("Scene3c");
        }
        public void SceneChange5b(){
               SceneManager.LoadScene("Scene5b");
        }
}
