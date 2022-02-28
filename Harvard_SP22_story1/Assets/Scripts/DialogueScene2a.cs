using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene2a : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1;
        public GameObject JasonFrown;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject NextButton;
        // public GameHandler gameHandler;
        // public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ArtChar1.SetActive(false);
        JasonFrown.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
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
                JasonFrown.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "Uhhh...my head... Where am I?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                JasonFrown.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Cubey";
                Char2speech.text = "Hi! I'm Cubey, your Unity Assistant! Would you like some assistance today?";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                JasonFrown.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                JasonFrown.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Cubey";
                Char2speech.text = "...";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                JasonFrown.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
                JasonFrown.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Cubey";
                Char2speech.text = "...";
        }
       else if (primeInt == 8){
                JasonFrown.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "AAAH?!? How the, who... what are you???";
                Char2name.text = "";
                Char2speech.text = "";
                // Choice1a.SetActive(true); // function Choice1aFunct()
                // Choice1b.SetActive(true); // function Choice1bFunct()
        }
        else if (primeInt == 9){
                JasonFrown.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Cubey";
                Char2speech.text = "I'm Cubey the 3D cube! You might recognize me as the great-great-great-grandson of Clippy the paper clip!";
        }
        else if (primeInt == 10){
                 JasonFrown.SetActive(true);
                 Char1name.text = "Jason";
                 Char1speech.text = "C-Clippy? Clippy died years ago... Clippy had children?";
                 Char2name.text = "";
                 Char2speech.text = "";
         }
         else if (primeInt == 11){
                  JasonFrown.SetActive(false);
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Cubey";
                  Char2speech.text = "It looks like you’re confused, Grandpa Clippy never died. Haven't you heard? He’s redebuting in Windows 11!";
          }
          else if (primeInt == 12){
                  JasonFrown.SetActive(true);
                  Char1name.text = "Jason";
                  Char1speech.text = "Okay... Anyhow, what is this place? Am I dead? ... Am I condemned to purgatory in UNITY?!";
                  Char2name.text = "";
                  Char2speech.text = "";
          }
          else if (primeInt == 13){
                   JasonFrown.SetActive(false);
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Cubey";
                   Char2speech.text = "It looks like you're agitated. Please calm down... You've just been transported into this build of Unity by some erroneous code... Would you like me to help?";
          }
          else if (primeInt == 14){
                  JasonFrown.SetActive(true);
                  Char1name.text = "Jason";
                  Char1speech.text = "My gosh, you really are related to Clippy huh... Sure, help me out.";
                  Char2name.text = "";
                  Char2speech.text = "";
          }
          else if (primeInt == 13){
                   JasonFrown.SetActive(false);
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Cubey";
                   Char2speech.text = "I recommend talking to the natives! They're sure to know the way out!";
          }
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                Char1name.text = "Jason";
                Char1speech.text = "Then you are no use to me, and must be silenced.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 101){
                Char1name.text = "Jason";
                Char1speech.text = "Come back here! Do not think you can hide from me!";
                Char2name.text = "";
                Char2speech.text = "";
                NextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);
        }

       else if (primeInt == 200){
                Char1name.text = "Jason";
                Char1speech.text = "Do not think you can fool me, human. Where will we find him?";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 201){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "You";
                Char2speech.text = "Ragu hangs out in a rough part of town. I'll take you now.";
                NextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "You";
                Char2speech.text = "I don't know what you're talking about!";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                NextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "You";
                Char2speech.text = "Sure, anything you want... just lay off the club.";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                NextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange1(){
               SceneManager.LoadScene("Scene2a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2b");
        }
}
