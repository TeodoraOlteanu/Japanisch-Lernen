using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision1 : MonoBehaviour
{
    public Text text1, text2, text3;
    private bool approach1=true, approach2 = true, approach3=true;
  
    private IEnumerator coroutine1, coroutine2, coroutine3;
    private float  WaitTime=5.0f;

    void OnCollisionEnter2D(Collision2D collisioninfo)
    {

        //SCENE 1

        if (collisioninfo.collider.name == "Body1")
        {

            if (approach1 == true)
            {
                text1.text = "Konnichiwa! I will be your japanese teacher throughout the game";
                approach1 = false;
            }

            coroutine1 = Konnichiwa(WaitTime);
            StartCoroutine(coroutine1);

            coroutine2 = Arigato(WaitTime);
            StartCoroutine(coroutine2);
            WaitTime = 0;

            coroutine3 = disappear(7.0f);
            StartCoroutine(coroutine3);

        }

        if (collisioninfo.collider.name == "star1")
            text3.text = "How do you say Thank you in japanese?";


        //SCENE2

        if (collisioninfo.collider.name == "Body2")
        {

            if (approach2 == true)
            {
                text1.text = "Oh! You made it this far!";
                approach2 = false;
            }
            coroutine1 = Watashi(WaitTime);
            StartCoroutine(coroutine1);

            coroutine2 = Desu(WaitTime);
            StartCoroutine(coroutine2);
            WaitTime = 0;

            coroutine3 = disappear(7.0f);
            StartCoroutine(coroutine3);

        }

        if (collisioninfo.collider.name == "star2")
            text3.text = "How do you say -I am Yuki- in japanse?";

        //SCENE3


        if (collisioninfo.collider.name == "Body3")
        {

            if (approach3 == true)
            {
                text1.text = "Time for another lesson!";
                approach3 = false;
            }

            coroutine1 = Ka(WaitTime);
            StartCoroutine(coroutine1);
            WaitTime = 0;

            coroutine3 = disappear(11.0f);
            StartCoroutine(coroutine3);

        }

        if (collisioninfo.collider.name == "star3")
            text3.text = "How do you ask Is it a cat in japanese? Cat = neko";

    }
    
    
    

    private IEnumerator Arigato(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        text1.text = "Arigato means thank you";
  
     
    }

    private IEnumerator Konnichiwa(float waitTime)
    {
          yield return new WaitForSeconds(waitTime);
            text2.text = "Konnichiwa! means Hello in japanase";
            
      
    }

    private IEnumerator Watashi(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        text1.text = "Watashi- means I in japanese, usually all substantives are the first in the sentence";

    }

    private IEnumerator Desu(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        text2.text = "desu means- it is- or -those are- or -I am-. It is placed at the end of the sentence, like any other verb";

   
    }

    private IEnumerator Ka(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        text2.text = "ka is a topic marker that shows a question, just like the '?', it is placed at the end of the sentence";


    }


    private IEnumerator disappear(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        text1.text = " ";
        text2.text = " ";

    }

}

