using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene3b : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
        public GameObject DialogueDisplay;
        public GameObject BlueChiefArt;
        public GameObject CubeyArt;
        public GameObject JasonFrown;
        public GameObject JasonSmile;
        public GameObject JasonNormal;
        public GameObject ArtBG1;
        public GameObject ArtBG2;
        public GameObject Choice4b;
        public GameObject Choice5b;
        public GameObject NextScene4bButton;
        public GameObject NextScene5bButton;
        public GameObject NextButton;
        // public GameHandler gameHandler;
        // public AudioSource audioSource;
        private bool allowSpace = true;
		private bool skip = false;

void Start(){         // initial visibility settings
        DialogueDisplay.SetActive(false);
        BlueChiefArt.SetActive(false);
        CubeyArt.SetActive(false);
        JasonFrown.SetActive(false);
        JasonSmile.SetActive(false);
        JasonNormal.SetActive(false);
        ArtBG1.SetActive(true);
        ArtBG2.SetActive(false);
        Choice4b.SetActive(false);
        Choice5b.SetActive(false);
        NextScene4bButton.SetActive(false);
        NextScene5bButton.SetActive(false);
        NextButton.SetActive(true);
		GameObject.Find("Hierarchy_Hall").GetComponent<AudioSource>().Play();
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
                BlueChiefArt.SetActive(true);
                JasonFrown.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "(The game object native leads me to an altar, and retrieves a folded up white scroll.)";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
				GameObject.Find("JasonHmm1").GetComponent<AudioSource>().Play();
        }
        else if (primeInt == 3){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Chief";
                Char3speech.text = "Take this O' Glorious Champion! It shall aid you in vanquishing our foes!";
                //gameHandler.AddPlayerStat(1);
				GameObject.Find("Native_Talk").GetComponent<AudioSource>().Play();
        }
        else if (primeInt == 4){
                Char1name.text = "Jason";
                Char1speech.text = "What does it do?";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
				GameObject.Find("JasonHmm2").GetComponent<AudioSource>().Play();
        }
        else if (primeInt == 5){
                JasonFrown.SetActive(false);
                JasonSmile.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Blue Chief";
                Char3speech.text = "Why it empowers the chosen one with ancient, godlike powers of creation, destruction, and manipulation!";
                //gameHandler.AddPlayerStat(1);
				GameObject.Find("Native_Startled").GetComponent<AudioSource>().Play();
        }
        else if (primeInt == 6){
                JasonSmile.SetActive(false);
                JasonFrown.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Blue Chief";
                Char3speech.text = "But be warned! Open it only at thy most opportune moment!";
				GameObject.Find("Native_Talk").GetComponent<AudioSource>().Play();
        }
        else if (primeInt == 7){
                JasonFrown.SetActive(false);
                JasonNormal.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "Blue Chief";
                Char3speech.text = "For misuse of this artifact will bring calamity to us all!";
				GameObject.Find("Native_Sad").GetComponent<AudioSource>().Play();
        }
        else if (primeInt == 8){
                JasonNormal.SetActive(false);
                JasonFrown.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "...";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
				GameObject.Find("JasonHmm1").GetComponent<AudioSource>().Play();
        }
        else if (primeInt == 9){
                Char1name.text = "Jason";
                Char1speech.text = "(I take the scroll from the Game Object...)";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
        }
        else if (primeInt == 10){
                Char1name.text = "Jason";
                Char1speech.text = "It is a smooth, sparkling clean papyrus roll that still faintly smells of the jungle...";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
				GameObject.Find("JasonHmm3").GetComponent<AudioSource>().Play();
        }
        else if (primeInt == 11){
                 Char1name.text = "Jason";
                 Char1speech.text = "(It has the words 'transform', 'rotate', and 'scale' hastily written on the side...)";
                 Char2name.text = "";
                 Char2speech.text = "";
                 Char3name.text = "";
                 Char3speech.text = "";
         }
         else if (primeInt == 12){
                  Char1name.text = "Jason";
                  Char1speech.text = "(This can't be ancient... or godlike)";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
          }
          else if (primeInt == 13){
                  Char1name.text = "Jason";
                  Char1speech.text = "Ummm... Mr. Game Object? Are you sure this will work?";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
				  GameObject.Find("JasonHmm2").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 14){
                   Char1name.text = "";
                   Char1speech.text = "";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "Blue Chief";
                   Char3speech.text = "Indubitably! It is your fate! Now off you go!";
				   GameObject.Find("Native_Talk").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 15){
                  BlueChiefArt.SetActive(false);
                  Char1name.text = "Jason";
                  Char1speech.text = "Okay...";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
				  GameObject.Find("JasonHmm1").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 16){
                  Char1name.text = "Jason";
                  Char1speech.text = "(Strange... If it's so powerful, why didn't they use this scroll themselves?)";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
          }
          else if (primeInt == 17){
                  Char1name.text = "Jason";
                  Char1speech.text = "(And why is it so new? It's almost as if it was just recently prepared...)";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
				  GameObject.Find("JasonHmm2").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 18){
                  Char1name.text = "Jason";
                  Char1speech.text = "(Something is definitely fishy here...)";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
          }
          else if (primeInt == 19){
                  CubeyArt.SetActive(true);
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Cubey";
                  Char2speech.text = "It seems like we're going on an adventure!";
                  Char3name.text = "";
                  Char3speech.text = "";
				  GameObject.Find("Cuby_Happy").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 20){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Cubey";
                  Char2speech.text = "We're gonna assist each other until the very end!";
                  Char3name.text = "";
                  Char3speech.text = "";
				  GameObject.Find("Cuby_Talk").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 21){
                  Char1name.text = "Jason";
                  Char1speech.text = "Haha, you really gotta do something about the way you speak cubey! Sure, lets assist each other until the very end!";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
				  GameObject.Find("JasonWow1").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 22){
                  Char1name.text = "Jason";
                  Char1speech.text = "(Despite the naturally annoying way Cubey is programmed to speak in... He's surprisingly wholesome.)";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
          }
          else if (primeInt == 23){
                  Char1name.text = "Jason";
                  Char1speech.text = "(Maybe his family lineage is not that bad after all...)";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
				  GameObject.Find("JasonHmm3").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 24){
                  Char1name.text = "Jason";
                  Char1speech.text = "(It looks like they genuinely want to help.)";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
          }
          else if (primeInt == 25){
                  ArtBG1.SetActive(false);
                  ArtBG2.SetActive(true);
                  Char1name.text = "Jason";
                  Char1speech.text = "(We enter a dark cavern with glowing red text dripping from the cave ceilings.)";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
				  GameObject.Find("Hierarchy_Hall").GetComponent<AudioSource>().Stop();
				  GameObject.Find("Console_Cave").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 26){
                  Char1name.text = "Jason";
                  Char1speech.text = "(The unnerving atmosphere is worsened by the occasional sound of something moving around deep inside the cave.)";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
          }
          else if (primeInt == 27){
                  Char1name.text = "Jason";
                  Char1speech.text = "(I steel myself and prepare for combat...but Cubey interrupts me)";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
          }
          else if (primeInt == 28){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Cubey";
                  Char2speech.text = "It seems like it is cubey's time to shine.";
                  Char3name.text = "";
                  Char3speech.text = "";
				  GameObject.Find("Cuby_Talk").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 29){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Cubey";
                  Char2speech.text = "Cubey has always wanted to be like the legendary excalibury.";
                  Char3name.text = "";
                  Char3speech.text = "";
				  GameObject.Find("Cuby_Sad").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 30){
                  Char1name.text = "";
                  Char1speech.text = "";
                  Char2name.text = "Cubey";
                  Char2speech.text = "Would you like to assist cubey today?";
                  Char3name.text = "";
                  Char3speech.text = "";
				  GameObject.Find("Cuby_Happy").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 31){
                  Char1name.text = "Jason";
                  Char1speech.text = "(Despite being literally a box of pixels, Cubey seems to look at me with puppy dog eyes.)";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
          }
          else if (primeInt == 32){
                  Char1name.text = "Jason";
                  Char1speech.text = "(I think he's wants me to use the scroll ON HIM.)";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
          }
          else if (primeInt == 33){
                  Char1name.text = "Jason";
                  Char1speech.text = "(What should I say?)";
                  Char2name.text = "";
                  Char2speech.text = "";
                  Char3name.text = "";
                  Char3speech.text = "";
                  NextButton.SetActive(false);
                  allowSpace = false;
				  skip = false;
				  CancelInvoke();
                  Choice4b.SetActive(true);
                  Choice5b.SetActive(true);
          }
          // Choice 4b
          else if (primeInt == 100){
                   Char1name.text = "Jason";
                   Char1speech.text = "As much as I'd love for you to assist me, I don't think that's the best idea.";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
				   GameObject.Find("JasonHurt2").GetComponent<AudioSource>().Play();
          }
          else if (primeInt == 101){
                   Char1name.text = "Jason";
                   Char1speech.text = "You can watch from the sidelines and cheer me on, like you always do!";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
                   NextButton.SetActive(false);
                   allowSpace = false;
				   skip = false;
				   CancelInvoke();
                   NextScene4bButton.SetActive(true);
          }

          // Choise 5b
          else if (primeInt == 200){
                   Char1name.text = "Jason";
                   Char1speech.text = "I'll let you be the hero today.";
                   Char2name.text = "";
                   Char2speech.text = "";
                   Char3name.text = "";
                   Char3speech.text = "";
                   NextButton.SetActive(false);
                   allowSpace = false;
				   skip = false;
				   CancelInvoke();
                   NextScene5bButton.SetActive(true);
				   GameObject.Find("JasonHmm1").GetComponent<AudioSource>().Play();
          }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice4bFunct(){
                JasonFrown.SetActive(false);
                JasonNormal.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "Cubey... Maybe you should sit out on this one...";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 99;
                Choice4b.SetActive(false);
                Choice5b.SetActive(false);
                NextButton.SetActive(true);
                allowSpace = true;
        }

        public void Choice5bFunct(){
                JasonFrown.SetActive(false);
                JasonSmile.SetActive(true);
                Char1name.text = "Jason";
                Char1speech.text = "You know what, Cubey... Sure.";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                primeInt = 199;
                Choice4b.SetActive(false);
                Choice5b.SetActive(false);
                NextButton.SetActive(true);
                allowSpace = true;
        }

        public void SceneChange4b(){
               SceneManager.LoadScene("Scene4b");
        }
        public void SceneChange5b(){
               SceneManager.LoadScene("Scene5b");
        }
}
