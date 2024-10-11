using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public float restartDelay = 2f;
  

    public void EndGame()
    {
        Destroy(GameObject.Find("Player"));
        Invoke("Restart", restartDelay);
    }

 

    public void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

