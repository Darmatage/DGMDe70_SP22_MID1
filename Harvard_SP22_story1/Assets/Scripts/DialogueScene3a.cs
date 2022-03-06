using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene3a : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
        public Text Char4name;
        public Text Char4speech;
        public GameObject DialogueDisplay;
        public GameObject CubeyArt;
        public GameObject JasonFrown;
        public GameObject JasonSmile;
        public GameObject JasonNormal;
        public GameObject ArtBG1;
        public GameObject Choice4a;
        public GameObject Choice4b;
        public GameObject NextScene4aButton;
        public GameObject NextScene4bButton;
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
        Choice4a.SetActive(false);
        Choice4b.SetActive(false);
        NextScene4aButton.SetActive(false);
        NextScene4bButton.SetActive(false);
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
                JasonSmile.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "(I wander around what I assume to be the project panel, amazed at how, despite being two-dimensional, everything still feels... normal.)";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
        }
        else if (primeInt == 3){
                JasonSmile.SetActive(false);
                JasonFrown.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "(I must have been using way too much Unity lately, because this is one trippy dream.)";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4){
                JasonFrown.SetActive(false);
                JasonNormal.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "(A landmark in the distance catches my eye. It looks like a dark gray protrusion on the horizon...)";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
        }
        else if (primeInt == 5){
                JasonNormal.SetActive(false);
                JasonSmile.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "(Is... is that a tab?)";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6){
                Char1name.text = "Jason";
                Char1speech.text = "(If I'm currently in the project panel... that must be the tab to the console!)";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
        }
        else if (primeInt == 7){
                Char1name.text = "Jason";
                Char1speech.text = "(I should be able to find it if I go there.)";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
        }
        else if (primeInt == 8){
                JasonSmile.SetActive(false);
                JasonFrown.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "(As I enter the console tab, the environment begins to darken and take on a reddish hue.)";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
        }
        else if (primeInt == 9){
                Char1name.text = "Jason";
                Char1speech.text = "Well, that's not a good sign...";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
        }
        else if (primeInt == 10){
                 Char1name.text = "Jason";
                 Char1speech.text = "(The air begins to thicken, and long lines of matrix-like text begin dripping from the ceiling...)";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";
                 Char4name.text = "";
                 Char4speech.text = "";
         }
         else if (primeInt == 11){
                  JasonFrown.SetActive(false);
                  JasonSmile.SetActive(true);
                  Char1name.text = "Jason";
                  Char1speech.text = "Wow... this place might be ominous, but it definitely looks cool.";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
                  Char4name.text = "";
                  Char4speech.text = "";
          }
          else if (primeInt == 12){
                  JasonSmile.SetActive(false);
                  JasonNormal.SetActive(true);
                  Char1name.text = "Jason";
                  Char1speech.text = "Now where is...";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
                  Char4name.text = "";
                  Char4speech.text = "";
          }
          else if (primeInt == 13){
                   Char1name.text = "Jason";
                   Char1speech.text = "(As I turn a corner, the silhouette of something large and insectoid flashes past the edge of my vision...)";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
                   Char4name.text = "";
                   Char4speech.text = "";
          }
          else if (primeInt == 14){
                  JasonNormal.SetActive(false);
                  JasonFrown.SetActive(true);
                  Char1name.text = "Jason";
                  Char1speech.text = "Great, I have to deal with literal bugs.";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
                  Char4name.text = "";
                  Char4speech.text = "";
          }
          else if (primeInt == 15){
                   JasonFrown.SetActive(false);
                   JasonSmile.SetActive(true);
                   Char1name.text = "Jason";
                   Char1speech.text = "Oh well, at least it's not some kind of fairytale mon-";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
                   Char4name.text = "";
                   Char4speech.text = "";
          }
          else if (primeInt == 16){
                   JasonSmile.SetActive(false);
                   JasonFrown.SetActive(true);
                   Char1name.text = "Jason";
                   Char1speech.text = "(A chill goes down my spine.)";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
                   Char4name.text = "";
                   Char4speech.text = "";
          }
          else if (primeInt == 17){
                   Char1name.text = "Jason";
                   Char1speech.text = "(That bug was the size of an ELEPHANT.)";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
                   Char4name.text = "";
                   Char4speech.text = "";
          }
          else if (primeInt == 18){
                   Char1name.text = "Jason";
                   Char1speech.text = "(What should I do)";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
                   Char4name.text = "";
                   Char4speech.text = "";
                   NextButton.SetActive(false);
                   allowSpace = false;
                   Choice4a.SetActive(true);
                   Choice4b.SetActive(true);
          }
          // Choice 4a
          else if (primeInt == 100){
                   Char1name.text = "Jason";
                   Char1speech.text = "(Time to make a run for it!)";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
                   Char4name.text = "";
                   Char4speech.text = "";
                   NextButton.SetActive(false);
                   allowSpace = false;
                   NextScene4aButton.SetActive(true);
          }

          // Choice 4b
          else if (primeInt == 200){
                   Char1name.text = "Jason";
                   Char1speech.text = "There's nothing to be afraid of!";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
                   Char4name.text = "";
                   Char4speech.text = "";
                   NextButton.SetActive(false);
                   allowSpace = false;
                   NextScene4bButton.SetActive(true);
          }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice4aFunct(){
                Char1name.text = "Jason";
                Char1speech.text = "You know what... Maybe I DO need Cubey's assistance.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 99;
                Choice4a.SetActive(false);
                Choice4b.SetActive(false);
                NextButton.SetActive(true);
                allowSpace = true;
        }

        public void Choice4bFunct(){
                JasonFrown.SetActive(false);
                JasonSmile.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "You got this, Jason. It's just some buggy code right?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                primeInt = 199;
                Choice4a.SetActive(false);
                Choice4b.SetActive(false);
                NextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange4a(){
               SceneManager.LoadScene("Scene4a");
        }
        public void SceneChange4b(){
               SceneManager.LoadScene("Scene4b");
        }
}
