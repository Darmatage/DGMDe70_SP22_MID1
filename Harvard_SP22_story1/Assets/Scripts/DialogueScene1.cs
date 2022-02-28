using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene1 : MonoBehaviour {
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
        public GameObject ArtBG2;
        public GameObject Choice1a;
        public GameObject Choice1b;
        public GameObject NextSceneButton;
        public GameObject NextButton;
        public GameObject DoubleClickButton;
        // public GameHandler gameHandler;
        // public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        ArtChar1.SetActive(false);
        JasonFrown.SetActive(false);
        ArtBG1.SetActive(true);
        ArtBG2.SetActive(false);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextSceneButton.SetActive(false);
        NextButton.SetActive(true);
        DoubleClickButton.SetActive(false);
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
                Char1speech.text = "Ahh it’s getting close to midnight, but I’ve still got to troubleshoot these student projects...";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "Jason";
                Char1speech.text = "Okay let’s see... what do I need to fix today...";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                Char1name.text = "Jason";
                Char1speech.text = "Hmm, everything seems normal.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 5){
                Char1name.text = "Jason";
                Char1speech.text = "Ah! He forgot a semi-colon again! How many times do I need to remind him?";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "Jason";
                Char1speech.text = "That should fix it now. Let’s see...";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "Jason";
                Char1speech.text = "Huh? Looks like there’s another error...";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 8){
                Char1name.text = "Jason";
                Char1speech.text = "Hmm... What’s this? I haven’t seen this kind of script before... Why does it look like it’s written in scrambled text?";
                Char2name.text = "";
                Char2speech.text = "";
                // Choice1a.SetActive(true); // function Choice1aFunct()
                // Choice1b.SetActive(true); // function Choice1bFunct()
        }
        else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "";
                NextButton.SetActive(false);
                allowSpace = false;
                DoubleClickButton.SetActive(true);
        }
        else if (primeInt == 10){
                 DoubleClickButton.SetActive(false);
                 // audioSource.Play();
                 ArtBG1.SetActive(false);
                 ArtBG2.SetActive(true);
                 Char1name.text = "Jason";
                 Char1speech.text = "What the...";
                 Char2name.text = "";
                 Char2speech.text = "";
                 NextButton.SetActive(false);
                 allowSpace = false;
                 NextSceneButton.SetActive(true);
                 // Choice1a.SetActive(true); // function Choice1aFunct()
                 // Choice1b.SetActive(true); // function Choice1bFunct()
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
                NextSceneButton.SetActive(true);
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
                // NextScene2Button.SetActive(true);
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

        public void SceneChange(){
               SceneManager.LoadScene("Scene2a");
        }
        // public void SceneChange2(){
        //         SceneManager.LoadScene("Scene2b");
        // }
}