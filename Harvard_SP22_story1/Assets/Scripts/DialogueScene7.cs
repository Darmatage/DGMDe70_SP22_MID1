using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene7 : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public GameObject DialogueDisplay;
        public GameObject ArtChar1;
        public GameObject JasonFrown;
        public GameObject JasonSmile;
        public GameObject JasonNormal;
        public GameObject ArtBG1;
        // public GameObject Choice1a;
        // public GameObject Choice1b;
        public GameObject NextSceneEndWinButton;
        public GameObject NextButton;
        // public GameHandler gameHandler;
        // public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ArtChar1.SetActive(false);
        JasonFrown.SetActive(false);
        JasonSmile.SetActive(false);
        JasonNormal.SetActive(false);
        ArtBG1.SetActive(true);
        // Choice1a.SetActive(false);
        // Choice1b.SetActive(false);
        NextSceneEndWinButton.SetActive(false);
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
                Char1speech.text = "(I hear a strange whooshing sound, and I lift my head from my desk abruptly.)";
                Char2name.text = "";
                Char2speech.text = "";
				GameObject.Find("JasonHurt2").GetComponent<AudioSource>().Play();
        }
       else if (primeInt == 3){
                Char1name.text = "Jason";
                Char1speech.text = "Huh? I was asleep?";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
				GameObject.Find("JasonHmm1").GetComponent<AudioSource>().Play();
        }
       else if (primeInt == 4){
                JasonFrown.SetActive(false);
                JasonNormal.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "What was that dream? That was way too real to have been a dream.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "Jason";
                Char1speech.text = "But… now that I’m trying to remember, I can’t recall any details…";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
				GameObject.Find("JasonHmm3").GetComponent<AudioSource>().Play();
        }
       else if (primeInt == 6){
                JasonNormal.SetActive(false);
                JasonSmile.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "So it was a dream.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 7){
                Char1name.text = "Jason";
                Char1speech.text = "In front of me is a clean, well organized Unity project.";
                Char2name.text = "";
                Char2speech.text = "";
				GameObject.Find("JasonHmm2").GetComponent<AudioSource>().Play();
        }
       else if (primeInt == 8){
                Char1name.text = "Jason";
                Char1speech.text = "It has lots of colorful pixel art assets and is totally error free…";
                Char2name.text = "";
                Char2speech.text = "";
                // Choice1a.SetActive(true); // function Choice1aFunct()
                // Choice1b.SetActive(true); // function Choice1bFunct()
        }
        else if (primeInt == 9){
                JasonSmile.SetActive(false);
                JasonNormal.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "Strangely enough, it isn’t made by any of the students though…";
                Char2name.text = "";
                Char2speech.text = "";
				GameObject.Find("JasonHmm3").GetComponent<AudioSource>().Play();
        }
        else if (primeInt == 10){
                 JasonNormal.SetActive(false);
                 JasonSmile.SetActive(true);
                 Char1name.text = "Jason";
                 Char1speech.text = "(Satisfied, mystified, and a bit sad for some reason, I close unity and head off to bed…)";
                 Char2name.text = "";
                 Char2speech.text = "";
                 NextButton.SetActive(false);
                 allowSpace = false;
                 NextSceneEndWinButton.SetActive(true);
         }
         else if (primeInt == 11){
                 Char1name.text = "Jason";
                 Char1speech.text = "(And for some inexplicable reason...)";
                 Char2name.text = "";
                 Char2speech.text = "";
         }
         else if (primeInt == 12){
                 Char1name.text = "Jason";
                 Char1speech.text = "(I feel a strong nostalgic urge to install Windows 11 first thing in the morning tomorrow.)";
                 Char2name.text = "";
                 Char2speech.text = "";
				 GameObject.Find("JasonWow2").GetComponent<AudioSource>().Play();
         }
         else if (primeInt == 13){
                 Char1name.text = "Jason";
                 Char1speech.text = "(Although Windows 11 is fresh out of the bakery, I feel that I’ll meet an old friend there for some reason…)";
                 Char2name.text = "";
                 Char2speech.text = "";
         }
         else if (primeInt == 14){
                 Char1name.text = "Jason";
                 Char1speech.text = "What a bizarre day.";
                 Char2name.text = "";
                 Char2speech.text = "";
         }
     }

        public void SceneEndWinChange(){
               SceneManager.LoadScene("End_Win");
        }
}
