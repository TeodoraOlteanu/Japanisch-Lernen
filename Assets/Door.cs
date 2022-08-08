using UnityEngine.SceneManagement;
using UnityEngine;

public class Door : MonoBehaviour
{
    public string nameScene;

    void OnCollisionEnter2D(Collision2D collisioninfo)
    {

        if (collisioninfo.collider.name == "door")
            SceneManager.LoadScene(nameScene);
    }

}
