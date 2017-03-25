using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneLoader : MonoBehaviour
{
    public string sceneToLoad;

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene(sceneToLoad);
        }
    }

    void Update()
    {
        // Go back to main beach scene
        if (SceneManager.GetActiveScene().name != "Beach" && Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(sceneToLoad);
        }

    }
}
