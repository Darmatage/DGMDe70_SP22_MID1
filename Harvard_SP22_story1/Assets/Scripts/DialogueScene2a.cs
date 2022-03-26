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
		GameObject.Find("Project_Prairie").GetComponent<AudioSource>().Play();
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
				GameObject.Find("JasonHmm1").GetComponent<AudioSource>().Play();
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
				GameObject.Find("Cuby_Happy").GetComponent<AudioSource>().Play();
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
				GameObject.Find("JasonHurt2").GetComponent<AudioSource>().Play();
        }
        else if (primeInt == 10){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Cubey";
                Char2speech.text = "I'm Cubey the 3D cube! You might recognize me as the great-great-great-grandson of Clippy the paper clip!";
				GameObject.Find("Cuby_Startled").GetComponent<AudioSource>().Play();
        }
        else if (primeInt == 11){
                 Char1name.text = "Jason";
                 Char1speech.text = "C-Clippy? Clippy died years ago... Clippy had children?";
                 Char2name.text = "";
                 Char2speech.text = "";
				 GameObject.Find("JasonWow2").GetComponent<AudioSource>().Play();
         }
         else if (primeInt == 12){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Cubey";
                  Char2speech.text = "It looks like you’re confused, Grandpa Clippy never died.";
				  GameObject.Find("Cuby_Talk").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 13){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Cubey";
                   Char2speech.text = "Haven't you heard? He’s redebuting in Windows 11!";
				   GameObject.Find("Cuby_Talk").GetComponent<AudioSource>().Play();
           }
          else if (primeInt == 14){
                  Char1name.text = "Jason";
                  Char1speech.text = "Okay... Anyhow, what is this place? Am I dead? ... Am I condemned to purgatory in UNITY?!";
                  Char2name.text = "";
                  Char2speech.text = "";
				  GameObject.Find("JasonNo2").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 15){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Cubey";
                   Char2speech.text = "It looks like you're agitated. Please calm down...";
				   GameObject.Find("Cuby_Sad").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 16){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Cubey";
                   Char2speech.text = "You've just been transported into this build of Unity by some erroneous code...";
				   GameObject.Find("Cuby_Talk").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 17){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Cubey";
                   Char2speech.text = "Would you like me to help?";
				   GameObject.Find("Cuby_Talk").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 18){
                  Char1name.text = "Jason";
                  Char1speech.text = "My gosh, you do sound just like Clippy huh... Sure, help me out.";
                  Char2name.text = "";
                  Char2speech.text = "";
				  GameObject.Find("JasonHmm3").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 19){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Cubey";
                   Char2speech.text = "I recommend talking to the natives! They might know the way out!";
				   GameObject.Find("Cuby_Happy").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 20){
                  Char1name.text = "Jason";
                  Char1speech.text = "Okay... So we're getting help from somewhere else huh. Classical clippy behavior.";
                  Char2name.text = "";
                  Char2speech.text = "";
				  GameObject.Find("JasonWow2").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 21){
                  Char1name.text = "Jason";
                  Char1speech.text = "Looking around, we're currently standing in a vast prairie that kinda looks like the project panel... maybe I can find a script to teleport myself back?";
                  Char2name.text = "";
                  Char2speech.text = "";
          }
		  else if (primeInt == 22){
                  Char1name.text = "Jason";
                  Char1speech.text = "But I also see some strange shapes and enticing lights in another direction...";
                  Char2name.text = "";
                  Char2speech.text = "";
				  GameObject.Find("JasonHmm2").GetComponent<AudioSource>().Play();
          }
		  else if (primeInt == 23){
                  Char1name.text = "Jason";
                  Char1speech.text = "Should I explore by myself or listen to Cubey?";
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
                   Char1speech.text = "I mean, you can tell this cube is a few screws loose just by looking at him.";
                   Char2name.text = "";
                   Char2speech.text = "";
				   GameObject.Find("JasonHmm3").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 101){
                   Char1name.text = "Jason";
                   Char1speech.text = "I know my way around unity, let's see if I can figure this out myself.";
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
				   GameObject.Find("JasonHmm1").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 201){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Cubey";
                   Char2speech.text = "Great! Let's be on our way.";
                   NextButton.SetActive(false);
                   allowSpace = false;
                   NextScene2bButton.SetActive(true);
				   GameObject.Find("Cuby_Happy").GetComponent<AudioSource>().Play();
          }

          // Choise 2c
          else if (primeInt == 300){
                   JasonFrown.SetActive(false);
                   JasonSmile.SetActive(true);
                   Char1name.text = "Jason";
                   Char1speech.text = "This is such a rare opportunity, so I'm going to check out all the sights here! Sayonara!";
                   Char2name.text = "";
                   Char2speech.text = "";
				   GameObject.Find("JasonWow1").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 301){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Cubey";
                   Char2speech.text = "Wait! Come back! Don't go off on your own, Jason!";
                   NextButton.SetActive(false);
                   allowSpace = false;
                   NextScene2cButton.SetActive(true);
				   GameObject.Find("Cuby_Startled").GetComponent<AudioSource>().Play();
          }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice3aFunct(){
                Char1name.text = "Jason";
                Char1speech.text = "I don't think listening to cubey is the right call.";
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
                Char1speech.text = "You know what Cubey?";
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
                Char1speech.text = "Sorry cubey, but I changed my mind.";
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
