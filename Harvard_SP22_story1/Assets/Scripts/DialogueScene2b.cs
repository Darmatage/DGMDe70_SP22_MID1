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
        public Text Char4name;
        public Text Char4speech;
        public GameObject DialogueDisplay;
        public GameObject CubeyArt;
        public GameObject CubeyArtSide;
        public GameObject BlueChiefArt;
        public GameObject JasonFrown;
        public GameObject JasonSmile;
        public GameObject JasonNormal;
        public GameObject ArtBG1;
        public GameObject ArtBG2;
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
        CubeyArtSide.SetActive(false);
        BlueChiefArt.SetActive(false);
        JasonFrown.SetActive(false);
        JasonSmile.SetActive(false);
        JasonNormal.SetActive(false);
        ArtBG1.SetActive(true);
        ArtBG2.SetActive(false);
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
                JasonFrown.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "I have no other plans, so I might as well take the friendly abstract cube's advice.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
        }
        else if (primeInt == 3){
                Char1name.text = "Jason";
                Char1speech.text = "Hey, wait up! Who are these natives that you speak of?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4){
                CubeyArt.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Cubey";
                Char2speech.text = "It looks like you’re curious! The natives who inhabit this land are the Game Objects. They come in many shapes and sizes, and they can do all sorts of interesting things.";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
        }
        else if (primeInt == 5){
                JasonFrown.SetActive(false);
                JasonSmile.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "Game Objects? I’m familiar with those...";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6){
                JasonSmile.SetActive(false);
                JasonFrown.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "Although if they all come to life like you do that might be a handful... I hope they are friendly.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
        }
        else if (primeInt == 7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Cubey";
                Char2speech.text = "Hahaha. It looks like you worry too much! They're very friendly, just like me!";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
        }
        else if (primeInt == 8){
                Char1name.text = "Jason";
                Char1speech.text = "Haha let’s hope they’re not like you at all...";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
        }
        else if (primeInt == 9){
                ArtBG1.SetActive(false);
                ArtBG2.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "(Cubey and I arrive at a magnificent hallway.)";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
        }
        else if (primeInt == 10){
                Char1name.text = "Jason";
                Char1speech.text = "(It is lined with huge illuminated cubes, each with its own unique item inside.)";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
        }
        else if (primeInt == 11){
                 Char1name.text = "Jason";
                 Char1speech.text = "(These must be the natives.)";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";
                 Char4name.text = "";
                 Char4speech.text = "";
         }
         else if (primeInt == 12){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "Narrator";
                  Char3speech.text = "As Jason approaches one of the cubes, the Game Objects all come to life and begin to glow brightly, some of which are a sickeningly saturated red color.";
                  Char4name.text = "";
                  Char4speech.text = "";
          }
          else if (primeInt == 13){
                  CubeyArt.SetActive(false);
                  CubeyArtSide.SetActive(true);
                  BlueChiefArt.SetActive(true);
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
                  Char4name.text = "Blue Chief";
                  Char4speech.text = "Oh Great Creator from high above, please save us!";
          }
          else if (primeInt == 14){
                   Char1name.text = "Jason";
                   Char1speech.text = "...me? Great creator? Well that’s an interesting way to put it... What's wrong?";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
                   Char4name.text = "";
                   Char4speech.text = "";
          }
          else if (primeInt == 15){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
                  Char4name.text = "Blue Chief";
                  Char4speech.text = "The errors! The errors have plagued us, breaking our parents and children! You must help us, O' Great Creator!";
          }
          else if (primeInt == 16){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
                   Char4name.text = "Blue Chief";
                   Char4speech.text = "Come with me, great champion! I will show you the key to defeating the errors!";
          }
          else if (primeInt == 17){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Cubey";
                  Char2speech.text = "It looks like an unexpected, unreasonably heavy responsibility has been unequivocally pushed onto you! Would you like to assist them?";
                  Char3name.text = "";
                  Char3speech.text = "";
                  Char4name.text = "";
                  Char4speech.text = "";
          }
          else if (primeInt == 18){
                  Char1name.text = "Jason";
                  Char1speech.text = "(Hmmm, this is all very sudden, and it could be dangerous... Then again, it's just a Unity error, I might be able to handle it myself. Or...)";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
                  Char4name.text = "";
                  Char4speech.text = "";
          }
          else if (primeInt == 19){
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
                   Char4name.text = "";
                   Char4speech.text = "";
          }
          else if (primeInt == 101){
                   Char1name.text = "Jason";
                   Char1speech.text = "I should take this chance to sneak away while he's still talking to himself...";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
                   Char4name.text = "";
                   Char4speech.text = "";
                   NextButton.SetActive(false);
                   allowSpace = false;
                   NextScene3aButton.SetActive(true);
          }

          // Choise 2b
          else if (primeInt == 200){
                   Char1name.text = "Jason";
                   Char1speech.text = "Show me the way, Big Blue Chief!";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
                   Char4name.text = "";
                   Char4speech.text = "";
                   NextButton.SetActive(false);
                   allowSpace = false;
                   NextScene3bButton.SetActive(true);
          }

          // Choise 2c
          else if (primeInt == 300){
                   Char1name.text = "Jason";
                   Char1speech.text = "I gotta get away from these things!";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
                   Char4name.text = "";
                   Char4speech.text = "";
          }
          else if (primeInt == 301){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "Cubey";
                   Char2speech.text = "Wait! Come back! Don't go off on your own, Jason!";
                   Char3name.text = "";
                   Char3speech.text = "";
                   Char4name.text = "";
                   Char4speech.text = "";
                   NextButton.SetActive(false);
                   allowSpace = false;
                   NextScene2cButton.SetActive(true);
          }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice3aFunct(){
                Char1name.text = "Jason";
                Char1speech.text = "I can do this myself!";
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
                JasonFrown.SetActive(false);
                JasonSmile.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "Of course I accept the quest. Who doesn't accept quests?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
                primeInt = 199;
                Choice3a.SetActive(false);
                Choice3b.SetActive(false);
                Choice2c.SetActive(false);
                NextButton.SetActive(true);
                allowSpace = true;
        }

        public void Choice2cFunct(){
                Char1name.text = "Jason";
                Char1speech.text = "I can't take this anymore... I gotta get away from these things!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
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
