using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene2c : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public GameObject DialogueDisplay;
        public GameObject JasonFrown;
        public GameObject JasonSmile;
        public GameObject JasonNormal;
        public GameObject ArtBG1;
		public GameObject ArtBG2;
        public GameObject Choice3a;
        public GameObject Choice3c;
        public GameObject NextScene3aButton;
        public GameObject NextScene3cButton;
        public GameObject NextButton;
        // public GameHandler gameHandler;
        // public AudioSource audioSource;
        private bool allowSpace = true;
		private bool skip = false;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        JasonFrown.SetActive(false);
        JasonSmile.SetActive(false);
        JasonNormal.SetActive(false);
        ArtBG1.SetActive(false);
		ArtBG2.SetActive(true);
        Choice3a.SetActive(false);
        Choice3c.SetActive(false);
        NextScene3aButton.SetActive(false);
        NextScene3cButton.SetActive(false);
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
                Char1name.text = "Jason";
                Char1speech.text = "(After a bit of light jogging, I find myself attracted to this green glow from beyond the horizon.)";
        }
        else if (primeInt == 3){
                Char1name.text = "Jason";
                Char1speech.text = "I wonder what that could be?";
                //gameHandler.AddPlayerStat(1);
				GameObject.Find("JasonHmm1").GetComponent<AudioSource>().Play();
        }
        else if (primeInt == 4){
                ArtBG1.SetActive(true);
				ArtBG2.SetActive(false);
				Char1name.text = "Jason";
                Char1speech.text = "(As I walk towards it, the scenery quickly changes to that of a lush jungle, filled with strange trees and large fungi.)";
				GameObject.Find("Project_Prairie").GetComponent<AudioSource>().Stop();
				GameObject.Find("Jungle_Search").GetComponent<AudioSource>().Play();
        }
        else if (primeInt == 5){
                JasonFrown.SetActive(false);
                JasonSmile.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "Whoa...";
                //gameHandler.AddPlayerStat(1);
				GameObject.Find("JasonWow2").GetComponent<AudioSource>().Play();
        }
        else if (primeInt == 6){
                JasonSmile.SetActive(false);
                JasonFrown.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "(I can faintly see lines of text deep in the jungle... and it reminds me of the inspector tab.)";
        }
        else if (primeInt == 7){
                JasonFrown.SetActive(false);
                JasonNormal.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "(Approaching one of the ferns, it seems to have a glowing box around it, and as I try to touch it, it blocks my hand from entering.)";
        }
        else if (primeInt == 8){
                JasonNormal.SetActive(false);
                JasonSmile.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "Is... is this a rigid body? And is that a collider?";
				GameObject.Find("JasonHmm2").GetComponent<AudioSource>().Play();
        }
        else if (primeInt == 9){
                Char1name.text = "Jason";
                Char1speech.text = "(I pick a flower and open it up... and it has components inside!)";
        }
        else if (primeInt == 10){
                Char1name.text = "Jason";
                Char1speech.text = "No way...";
				GameObject.Find("JasonWow1").GetComponent<AudioSource>().Play();
        }
        else if (primeInt == 11){
                 Char1name.text = "Jason";
                 Char1speech.text = "(I tweak the scale of the flower... and it begins to balloon into the size of a house!)";
         }
         else if (primeInt == 12){
                  Char1name.text = "Jason";
                  Char1speech.text = "This is amazing! This place must be the Inspector!";
				  GameObject.Find("JasonWow2").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 13){
                  Char1name.text = "Jason";
                  Char1speech.text = "(I could mess with these and create a whole world here...)";
          }
          else if (primeInt == 14){
                   Char1name.text = "Jason";
                   Char1speech.text = "(I can create castles out of vines, make trees fall from the sky like rain.)";
          }
          else if (primeInt == 15){
                  Char1name.text = "Jason";
                  Char1speech.text = "(And maybe even turn myself into a unicorn!)";
          }
          else if (primeInt == 16){
                  JasonSmile.SetActive(false);
                  JasonFrown.SetActive(true);
                  Char1name.text = "Jason";
                  Char1speech.text = "I could definitely see myself getting carried away with this...";
				  GameObject.Find("JasonHmm3").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 17){
                  Char1name.text = "Jason";
                  Char1speech.text = "(What should I do)";
                  NextButton.SetActive(false);
                  allowSpace = false;
				  skip = false;
				  CancelInvoke();
                  Choice3a.SetActive(true);
                  Choice3c.SetActive(true);
          }
          // Choice 3a
          else if (primeInt == 100){
                   Char1name.text = "Jason";
                   Char1speech.text = "I'd better go back to Cubey.";
                   NextButton.SetActive(false);
                   allowSpace = false;
				   skip = false;
				   CancelInvoke();
                   NextScene3aButton.SetActive(true);
				   GameObject.Find("JasonHmm1").GetComponent<AudioSource>().Play();
          }

          // Choise 3c
          else if (primeInt == 200){
                   Char1name.text = "Jason";
                   Char1speech.text = "Let's see what this does...";
                   NextButton.SetActive(false);
                   allowSpace = false;
				   skip = false;
				   CancelInvoke();
                   NextScene3cButton.SetActive(true);
				   GameObject.Find("JasonHmm1").GetComponent<AudioSource>().Play();
          }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice3aFunct(){
                JasonFrown.SetActive(false);
                JasonNormal.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "Yeah, this could be dangerous...";
                primeInt = 99;
                Choice3a.SetActive(false);
                Choice3c.SetActive(false);
                NextButton.SetActive(true);
                allowSpace = true;
        }

        public void Choice3cFunct(){
                JasonFrown.SetActive(false);
                JasonSmile.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "Having a little fun never hurts!";
                primeInt = 199;
                Choice3a.SetActive(false);
                Choice3c.SetActive(false);
                NextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange3a(){
               SceneManager.LoadScene("Scene3a");
        }
        public void SceneChange3c(){
               SceneManager.LoadScene("Scene3c");
        }
}
