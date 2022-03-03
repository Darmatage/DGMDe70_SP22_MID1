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
        // public Text Char3name;
        // public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject CubeyArt;
        public GameObject CubeyTransform;
        public GameObject JasonFrown;
        public GameObject JasonSmile;
        public GameObject JasonNormal;
        public GameObject ArtBG1;
        public GameObject ArtBG2;
        public GameObject Choice3a;
        public GameObject Choice2b;
        public GameObject Choice2c;
        public GameObject NextScene3aButton;
        public GameObject NextScene2bButton;
        public GameObject NextScene2cButton;
        public GameObject NextButton;
        // public GameHandler gameHandler;
        // public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        CubeyArt.SetActive(false);
        CubeyTransform.SetActive(false);
        JasonFrown.SetActive(false);
        JasonSmile.SetActive(false);
        JasonNormal.SetActive(false);
        ArtBG1.SetActive(true);
        ArtBG2.SetActive(false);
        Choice3a.SetActive(false);
        Choice2b.SetActive(false);
        Choice2c.SetActive(false);
        NextScene3aButton.SetActive(false);
        NextScene2bButton.SetActive(false);
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
                JasonFrown.SetActive(true);
                DialogueDisplay.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "Uhhh...my head... Where am I?";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 3){
                 ArtBG1.SetActive(false);
                 ArtBG2.SetActive(true);
                 CubeyTransform.SetActive(true);
                 Char1name.text = "";
                 Char1speech.text = "";
                 Char2name.text = "";
                 Char2speech.text = "";
         }
         else if (primeInt == 4){
                CubeyTransform.SetActive(false);
                CubeyArt.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Cubey";
                Char2speech.text = "Hi! I'm Cubey, your Unity Assistant! Would you like some assistance today?";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 5){
                Char1name.text = "Jason";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Cubey";
                Char2speech.text = "......";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 7){
                Char1name.text = "Jason";
                Char1speech.text = ".........";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Cubey";
                Char2speech.text = "............";
        }
       else if (primeInt == 9){
                Char1name.text = "Jason";
                Char1speech.text = "AAAH?!? How the, who... what are you???";
                Char2name.text = "";
                Char2speech.text = "";
                // Choice1a.SetActive(true); // function Choice1aFunct()
                // Choice1b.SetActive(true); // function Choice1bFunct()
        }
        else if (primeInt == 10){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Cubey";
                Char2speech.text = "I'm Cubey the 3D cube! You might recognize me as the great-great-great-grandson of Clippy the paper clip!";
        }
        else if (primeInt == 11){
                 Char1name.text = "Jason";
                 Char1speech.text = "C-Clippy? Clippy died years ago... Clippy had children?";
                 Char2name.text = "";
                 Char2speech.text = "";
         }
         else if (primeInt == 12){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Cubey";
                  Char2speech.text = "It looks like you’re confused, Grandpa Clippy never died. Haven't you heard? He’s redebuting in Windows 11!";
          }
          else if (primeInt == 13){
                  Char1name.text = "Jason";
                  Char1speech.text = "Okay... Anyhow, what is this place? Am I dead? ... Am I condemned to purgatory in UNITY?!";
                  Char2name.text = "";
                  Char2speech.text = "";
          }
          else if (primeInt == 14){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Cubey";
                   Char2speech.text = "It looks like you're agitated. Please calm down... You've just been transported into this build of Unity by some erroneous code... Would you like me to help?";
          }
          else if (primeInt == 15){
                  Char1name.text = "Jason";
                  Char1speech.text = "My gosh, you really are related to Clippy huh... Sure, help me out.";
                  Char2name.text = "";
                  Char2speech.text = "";
          }
          else if (primeInt == 16){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Cubey";
                   Char2speech.text = "I recommend talking to the natives! They're sure to know the way out!";
          }
          else if (primeInt == 17){
                  Char1name.text = "Jason";
                  Char1speech.text = "I can see this Clippy-relative getting on my nerves if I stay with him...";
                  Char2name.text = "";
                  Char2speech.text = "";
          }
          else if (primeInt == 18){
                  Char1name.text = "Jason";
                  Char1speech.text = "What should I do?";
                  Char2name.text = "";
                  Char2speech.text = "";
                  NextButton.SetActive(false);
                  allowSpace = false;
                  Choice3a.SetActive(true);
                  Choice2b.SetActive(true);
                  Choice2c.SetActive(true);
          }
          // Choice 3a
          else if (primeInt == 100){
                   Char1name.text = "Jason";
                   Char1speech.text = "I mean, you can tell he's already a few screws loose from just looking at him.";
                   Char2name.text = "";
                   Char2speech.text = "";
          }
          else if (primeInt == 101){
                   Char1name.text = "Jason";
                   Char1speech.text = "I should take this chance to sneak away while he's still talking to himself...";
                   Char2name.text = "";
                   Char2speech.text = "";
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
          }
          else if (primeInt == 201){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Cubey";
                   Char2speech.text = "Great! Let's be on our way.";
                   NextButton.SetActive(false);
                   allowSpace = false;
                   NextScene2bButton.SetActive(true);
          }

          // Choise 2c
          else if (primeInt == 300){
                   JasonFrown.SetActive(false);
                   JasonSmile.SetActive(true);
                   Char1name.text = "Jason";
                   Char1speech.text = "This is such a rare opportunity, so I'm going to check out all the sights here! Sayonara!";
                   Char2name.text = "";
                   Char2speech.text = "";
          }
          else if (primeInt == 301){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Cubey";
                   Char2speech.text = "Wait! Come back! Don't go off on your own, Jason!";
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
                primeInt = 99;
                Choice3a.SetActive(false);
                Choice2b.SetActive(false);
                Choice2c.SetActive(false);
                NextButton.SetActive(true);
                allowSpace = true;
        }

        public void Choice2bFunct(){
                JasonFrown.SetActive(false);
                JasonSmile.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "You know what, Cubey?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 199;
                Choice3a.SetActive(false);
                Choice2b.SetActive(false);
                Choice2c.SetActive(false);
                NextButton.SetActive(true);
                allowSpace = true;
        }

        public void Choice2cFunct(){
                Char1name.text = "Jason";
                Char1speech.text = "Why should I listen to you!?";
                Char2name.text = "";
                Char2speech.text = "";
                primeInt = 299;
                Choice3a.SetActive(false);
                Choice2b.SetActive(false);
                Choice2c.SetActive(false);
                NextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange3a(){
               SceneManager.LoadScene("Scene3a");
        }
        public void SceneChange2b(){
               SceneManager.LoadScene("Scene2b");
        }
        public void SceneChange2c(){
               SceneManager.LoadScene("Scene2c");
        }
}
