using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene2b : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject CubeyArt;
        public GameObject JasonFrown;
        public GameObject ArtBG1;
        public GameObject Choice3a;
        public GameObject Choice3b;
        public GameObject Choice2c;
        public GameObject NextScene3aButton;
        public GameObject NextScene3bButton;
        public GameObject NextScene2cButton;
        public GameObject NextButton;
        // public GameHandler gameHandler;
        // public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        CubeyArt.SetActive(false);
        JasonFrown.SetActive(false);
        ArtBG1.SetActive(true);
        Choice3a.SetActive(false);
        Choice3b.SetActive(false);
        Choice2c.SetActive(false);
        NextScene3aButton.SetActive(false);
        NextScene3bButton.SetActive(false);
        NextScene2cButton.SetActive(false);
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
                Char1name.text = "";
                Char1speech.text = "Listening to Cubey's advice, Jason goes looking for the natives of Unity.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "";
                Char1speech.text = "At the Hall, the native Game Objects approach Jason as if he is a god";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Game Objects";
                Char3speech.text = "Oh Great Creator from high above, please save us from the errors that plague us!";
        }
       else if (primeInt == 5){
                JasonFrown.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Game Objects";
                Char3speech.text = "Those errors mustn't be challenged alone! You must seek help from the sacred scripts!";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                JasonFrown.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==7){
                JasonFrown.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Cubey";
                Char2speech.text = "...";
                Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt == 8){
                JasonFrown.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "AAAH?!? How the, who... what are you???";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                // Choice1a.SetActive(true); // function Choice1aFunct()
                // Choice1b.SetActive(true); // function Choice1bFunct()
        }
        else if (primeInt == 9){
                JasonFrown.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Cubey";
                Char2speech.text = "I'm Cubey the 3D cube! You might recognize me as the great-great-great-grandson of Clippy the paper clip!";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 10){
                 JasonFrown.SetActive(true);
                 Char1name.text = "Jason";
                 Char1speech.text = "C-Clippy? Clippy died years ago... Clippy had children?";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";
         }
         else if (primeInt == 11){
                  JasonFrown.SetActive(false);
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Cubey";
                  Char2speech.text = "It looks like you’re confused, Grandpa Clippy never died. Haven't you heard? He’s redebuting in Windows 11!";
                  Char3name.text = "";
                  Char3speech.text = "";
          }
          else if (primeInt == 12){
                  JasonFrown.SetActive(true);
                  Char1name.text = "Jason";
                  Char1speech.text = "Okay... Anyhow, what is this place? Am I dead? ... Am I condemned to purgatory in UNITY?!";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
          }
          else if (primeInt == 13){
                   JasonFrown.SetActive(false);
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Cubey";
                   Char2speech.text = "It looks like you're agitated. Please calm down... You've just been transported into this build of Unity by some erroneous code... Would you like me to help?";
                   Char3name.text = "";
                   Char3speech.text = "";
          }
          else if (primeInt == 14){
                  JasonFrown.SetActive(true);
                  Char1name.text = "Jason";
                  Char1speech.text = "My gosh, you really are related to Clippy huh... Sure, help me out.";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
          }
          else if (primeInt == 13){
                   JasonFrown.SetActive(false);
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Cubey";
                   Char2speech.text = "I recommend talking to the natives! They're sure to know the way out!";
                   Char3name.text = "";
                   Char3speech.text = "";
          }
          else if (primeInt == 15){
                  JasonFrown.SetActive(true);
                  Char1name.text = "Jason";
                  Char1speech.text = "I can see this Clippy-relative getting on my nerves if I stay with him...";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
          }
          else if (primeInt == 16){
                  Char1name.text = "Jason";
                  Char1speech.text = "What should I do?";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
                  NextButton.SetActive(false);
                  allowSpace = false;
                  Choice3a.SetActive(true);
                  Choice3b.SetActive(true);
                  Choice2c.SetActive(true);
          }
          // Choice 3a
          else if (primeInt == 100){
                   Char1name.text = "Jason";
                   Char1speech.text = "I mean, you can tell he's already a few screws loose from just looking at him.";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
          }
          else if (primeInt == 101){
                   Char1name.text = "Jason";
                   Char1speech.text = "I should take this chance to sneak away while he's still talking to himself...";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
                   NextButton.SetActive(false);
                   allowSpace = false;
                   NextScene3aButton.SetActive(true);
          }

          // Choise 2b
          else if (primeInt == 200){
                   Char1name.text = "Jason";
                   Char1speech.text = "I think you're right. Let's go find the natives.";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
          }
          else if (primeInt == 201){
                   JasonFrown.SetActive(false);
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Cubey";
                   Char2speech.text = "Great! Let's be on our way.";
                   Char3name.text = "";
                   Char3speech.text = "";
                   NextButton.SetActive(false);
                   allowSpace = false;
                   NextScene3bButton.SetActive(true);
          }

          // Choise 2c
          else if (primeInt == 300){
                   Char1name.text = "Jason";
                   Char1speech.text = "This is such a rare opportunity, so I'm going to check out all the sights here! Sayonara!";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
          }
          else if (primeInt == 301){
                   JasonFrown.SetActive(false);
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Cubey";
                   Char2speech.text = "Wait! Come back! Don't go off on your own, Jason!";
                   Char3name.text = "";
                   Char3speech.text = "";
                   NextButton.SetActive(false);
                   allowSpace = false;
                   NextScene2cButton.SetActive(true);
          }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice3aFunct(){
                Char1name.text = "Jason";
                Char1speech.text = "I don't think listening to him is the right move here.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 99;
                Choice3a.SetActive(false);
                Choice3b.SetActive(false);
                Choice2c.SetActive(false);
                NextButton.SetActive(true);
                allowSpace = true;
        }

        public void Choice3bFunct(){
                Char1name.text = "Jason";
                Char1speech.text = "You know what, Cubey?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 199;
                Choice3a.SetActive(false);
                Choice3b.SetActive(false);
                Choice2c.SetActive(false);
                NextButton.SetActive(true);
                allowSpace = true;
        }

        public void Choice2cFunct(){
                Char1name.text = "Jason";
                Char1speech.text = "Why should I listen to you!?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 299;
                Choice3a.SetActive(false);
                Choice3b.SetActive(false);
                Choice2c.SetActive(false);
                NextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange3a(){
               SceneManager.LoadScene("Scene3a");
        }
        public void SceneChange3b(){
               SceneManager.LoadScene("Scene3b");
        }
        public void SceneChange2c(){
               SceneManager.LoadScene("Scene2c");
        }
}
