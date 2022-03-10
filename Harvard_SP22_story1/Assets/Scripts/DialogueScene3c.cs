using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene3c : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public GameObject DialogueDisplay;
        public GameObject JasonFrown;
        public GameObject JasonSmile;
        public GameObject JasonNormal;
        public GameObject ArtBG1;
        // public GameObject Choice5a;
        public GameObject NextScene5aButton;
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
        // Choice5a.SetActive(false);
        NextScene5aButton.SetActive(false);
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
                Char1name.text = "Jason";
                Char1speech.text = "(By the time I realize it, I’m already deep inside a dense, alien jungle.)";
        }
        else if (primeInt == 3){
                Char1name.text = "Jason";
                Char1speech.text = "(Unlike the other places I’ve visited today, this place feels so much more... safe.)";
                //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4){
                Char1name.text = "Jason";
                Char1speech.text = "(And it’s beckoning for me to explore more.)";
        }
        else if (primeInt == 5){
                JasonFrown.SetActive(false);
                JasonSmile.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "(Tired of all of this 'transported to another world' business, my first thought is to punch the tree next to me...)";
                //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6){
                JasonSmile.SetActive(false);
                JasonFrown.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "If I’m in a game engine, the point should be to have fun, right?";
        }
        else if (primeInt == 7){
                JasonFrown.SetActive(false);
                JasonNormal.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "Everything so far has been boring at best and downright crazy at worst.";
        }
        else if (primeInt == 8){
                JasonNormal.SetActive(false);
                JasonSmile.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "(I give this poor tree Jason’s specialty knuckle-sandwich...)";
        }
        else if (primeInt == 9){
                Char1name.text = "Jason";
                Char1speech.text = "(A second of delay later, it does exactly what my gamer brain imagined it would...)";
        }
        else if (primeInt == 10){
                Char1name.text = "Jason";
                Char1speech.text = "(It breaks into a dozen or so manageable pieces of wood!)";
        }
        else if (primeInt == 11){
                 Char1name.text = "Jason";
                 Char1speech.text = "Oh wow, you know what, this is so much easier than I thought!";
         }
         else if (primeInt == 12){
                  Char1name.text = "Jason";
                  Char1speech.text = "(I pull on a set of vines, and the whole forest seems to move, rotate, and transform at my will.)";
          }
          else if (primeInt == 13){
                  Char1name.text = "Jason";
                  Char1speech.text = "Haha now that’s what I’m talking about! Finally time for some fun!";
          }
          else if (primeInt == 14){
                   Char1name.text = "Jason";
                   Char1speech.text = "(It seems that I can instinctively edit and change everything around me.)";
          }
          else if (primeInt == 15){
                  Char1name.text = "Jason";
                  Char1speech.text = "(Just like in a lucid dream... but even better!))";
          }
          else if (primeInt == 16){
                  JasonSmile.SetActive(false);
                  JasonFrown.SetActive(true);
                  Char1name.text = "Jason";
                  Char1speech.text = "(Like a newborn deity who’s been dropped into an infinite playground,)";
          }
          else if (primeInt == 17){
                  Char1name.text = "Jason";
                  Char1speech.text = "(I gleefully grin as I wield this newfound power.)";
          }
          else if (primeInt == 18){
                  Char1name.text = "Jason";
                  Char1speech.text = "(My creative abilities are limited only by my own imagination!)";
          }
          else if (primeInt == 19){
                  Char1name.text = "Jason";
                  Char1speech.text = "Hahahaha!";
          }
          else if (primeInt == 20){
                  Char1name.text = "Jason";
                  Char1speech.text = "(I build civilizations in the blink of an eye,)";
          }
          else if (primeInt == 21){
                  Char1name.text = "Jason";
                  Char1speech.text = "(create mind boggling factories with a swipe of the hand,)";
          }
          else if (primeInt == 22){
                  Char1name.text = "Jason";
                  Char1speech.text = "(and create dungeons (and raid them!) in the span of what feels like minutes...)";
          }
          else if (primeInt == 22){
                  Char1name.text = "Jason";
                  Char1speech.text = "(The experience is absolutely absorbing.)";
          }
          else if (primeInt == 23){
                  Char1name.text = "Jason";
                  Char1speech.text = "Just... a little... bit... more...";
                  NextScene5aButton.SetActive(true);
          }
          // Choice 5a
          else if (primeInt == 100){
                   Char1name.text = "Jason";
                   Char1speech.text = "I'd better go back to Cubey.";
                   NextButton.SetActive(false);
                   allowSpace = false;
                   NextButton.SetActive(false);
                   allowSpace = false;
                   // Choice5a.SetActive(true);
                   NextScene5aButton.SetActive(true);
          }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice5aFunct(){
                JasonFrown.SetActive(false);
                JasonNormal.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "Yeah, this could be dangerous...";
                primeInt = 99;
                // Choice5a.SetActive(false);
                NextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange5a(){
               SceneManager.LoadScene("Scene5a");
        }
}
