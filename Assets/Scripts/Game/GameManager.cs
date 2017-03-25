using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static Vector3 playerPosition = Vector3.zero;
    public static Vector3 camPosition = Vector3.zero;

    public static bool canPickUpShell;
    private Transform player;
    private Transform cam;

	public static GameManager Instance
    {
        get;
        protected set;
    }
	
    public void Awake() 
    {
        //if there is already an instance, destroy it.
        if ( Instance != null )
        {
            Destroy( Instance.gameObject );
        }

        //assign the static variable to be this object, so we can get it from anywhere
        Instance = this;

        //Unity will never automatically destroy this object
        DontDestroyOnLoad( gameObject );
    }


    void Start()
    {
        canPickUpShell = false;

        if (SceneManager.GetActiveScene().name == "Beach")
        {
            player = GameObject.Find("Player").transform;
            player.position = playerPosition;

            cam = GameObject.Find("Main Camera").transform;
            cam.position = camPosition;
        }

    }
}
