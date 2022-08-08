using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private InputField input;
    public Text text1; 
    public string nameScene;
    public Text gameend;
   

    void Awake()
    {
        input = GameObject.Find("Answer").GetComponent<InputField>();
    }

    public void GetInput(string guess)
    {
        if (nameScene == "Scene1")
        {
            if (input.text == "Arigato")
            {
                text1.text = "Congratulations! You answered correct!";
                nameScene = "Scene2";
                SceneManager.LoadScene(nameScene);
            }
            else
                text1.text = "Try again";
        }

        if(nameScene=="Scene2")
        {
            if (input.text == "Watashi Yuki desu")
            {
                text1.text = "Congratulations! You answered correct!";
                nameScene = "Scene3";
                Debug.Log("Scene3");
                SceneManager.LoadScene(nameScene);
            }
            else
                text1.text = "Try again";
        }

        if (nameScene == "Scene3")
        {
            
            if (input.text == "Neko desu ka")
            {
                text1.text = "Congratulations! You answered correct!";
                gameend.text = "Congratulations! You finished the game!";

            }
            else
                text1.text = "Try again";

        }

        input.text = "";
    }


}
