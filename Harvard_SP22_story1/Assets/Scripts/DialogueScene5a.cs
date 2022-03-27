using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene5a : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public GameObject DialogueDisplay;
        public GameObject JasonFrown;
        public GameObject JasonSmile;
        public GameObject JasonNormal;
        public GameObject ArtBG1;
		public GameObject ArtBG2;
        public GameObject NextSceneEndLoseButton;
        public GameObject NextButton;
        // public GameHandler gameHandler;
        // public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        JasonFrown.SetActive(false);
        JasonSmile.SetActive(false);
        JasonNormal.SetActive(false);
        ArtBG1.SetActive(true);
		ArtBG2.SetActive(false);
        NextSceneEndLoseButton.SetActive(false);
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
                Char1speech.text = "(I lurch up from my desk in a cold sweat.)";
                Char2name.text = "";
                Char2speech.text = "";
				GameObject.Find("JasonHurt2").GetComponent<AudioSource>().Play();
        }
       else if (primeInt == 3){
                Char1name.text = "Jason";
                Char1speech.text = "(I instinctively check my body... and it's back to normal.)";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                JasonFrown.SetActive(false);
                JasonNormal.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "Oh... oh okay. I'm back.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                JasonNormal.SetActive(false);
                JasonFrown.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "Well that was an intense...";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
				GameObject.Find("JasonWow1").GetComponent<AudioSource>().Play();
        }
       else if (primeInt == 6){
                Char1name.text = "Jason";
                Char1speech.text = "(The C# script that I last remember opening... turns out to be a pile of garbled mess...)";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 7){
                JasonFrown.SetActive(false);
                JasonNormal.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "I must have fallen asleep with exhaustion at the sheer sight of it.";
                Char2name.text = "";
                Char2speech.text = "";
				GameObject.Find("JasonHmm1").GetComponent<AudioSource>().Play();
        }
       else if (primeInt == 8){
                Char1name.text = "Jason";
                Char1speech.text = "What a strange, strange dream...";
                Char2name.text = "";
                Char2speech.text = "";
        }
        else if (primeInt == 9){
                Char1name.text = "Jason";
                Char1speech.text = "Let's check the files again...";
				GameObject.Find("JasonHmm2").GetComponent<AudioSource>().Play();
        }
        else if (primeInt == 10){
                 JasonNormal.SetActive(false);
                 JasonFrown.SetActive(true);
                 Char1name.text = "Jason";
                 Char1speech.text = "Huh? Strange...";
                 Char2name.text = "";
                 Char2speech.text = "";
         }
         else if (primeInt == 11){
                 Char1name.text = "Jason";
                 Char1speech.text = "It seems like the unity project with the crazy code...";
				 GameObject.Find("JasonHmm3").GetComponent<AudioSource>().Play();
         }
         else if (primeInt == 12){
                 Char1name.text = "Jason";
                 Char1speech.text = "didn't belong to any of the students...";
         }
         else if (primeInt == 13){
                 Char1name.text = "Jason";
                 Char1speech.text = "What the...?";
         }
         else if (primeInt == 14){
                 Char1name.text = "Jason";
                 Char1speech.text = "(A chill goes down my spine...)";
         }
         else if (primeInt == 15){
                 Char1name.text = "Jason";
                 Char1speech.text = "That... was a dream, right?";
				 GameObject.Find("JasonWow1").GetComponent<AudioSource>().Play();
         }
         else if (primeInt == 16){
                 JasonFrown.SetActive(false);
                 JasonNormal.SetActive(true);
                 Char1name.text = "Jason";
                 Char1speech.text = "You know what...";
         }
         else if (primeInt == 17){
                 Char1name.text = "Jason";
                 Char1speech.text = "I don't feel well rested even after that nap...";
         }
         else if (primeInt == 18){
                 Char1name.text = "Jason";
                 Char1speech.text = "I should just go to bed.";
				 GameObject.Find("JasonHmm1").GetComponent<AudioSource>().Play();
         }
         else if (primeInt == 19){
                 ArtBG1.SetActive(false);
				 ArtBG2.SetActive(true);
				 Char1name.text = "Jason";
                 Char1speech.text = "All I gotta do is close the computer and...";
         }
         else if (primeInt == 20){
				 Char1name.text = "Jason";
                 Char1speech.text = "Goodnight!";
                 NextButton.SetActive(false);
                 allowSpace = false;
                 NextSceneEndLoseButton.SetActive(true);
         }
     }

        public void SceneEndLoseChange(){
               SceneManager.LoadScene("End_Lose");
        }
}
