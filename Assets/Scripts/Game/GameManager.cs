﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int curShells = 0;
    public static int winShells = 3;

    public static Vector3 playerPosition = Vector3.zero;
    public static Vector3 camPosition = Vector3.zero;

    public static bool canPickUpShell = false;
    public static bool hasCan = false;
    public static bool hasStick = false;

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
        if (Instance != null)
        {
            Destroy(Instance.gameObject);
        }

        //assign the static variable to be this object, so we can get it from anywhere
        Instance = this;

        //Unity will never automatically destroy this object
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Beach")
        {
            player = GameObject.Find("Player").transform;
            player.position = playerPosition;

            cam = GameObject.Find("Main Camera").transform;
            cam.position = camPosition;

            if (hasCan)
            {
                GameObject.Find("CanEmpty").transform.gameObject.SetActive(false);
            }

            if (hasStick)
            {
                GameObject.Find("Stick").transform.gameObject.SetActive(false);
            }

            if (canPickUpShell)
            {
                GameObject.Find("Crab").transform.Find("Shell").gameObject.SetActive(false);
                GameObject.Find("Crab").transform.Find("CanWithCrab").gameObject.SetActive(true);
            }
        }

        if (SceneManager.GetActiveScene().name == "Crab")
        {
            if (hasCan)
            {
                GameObject.Find("CanFollower").transform.Find("CanFollowerPrefab").gameObject.SetActive(true);
            }

            if (canPickUpShell) 
            {
                GameObject.Find("Crab").transform.Find("Shell").gameObject.SetActive(false);
                GameObject.Find("Crab").transform.Find("CanWithCrab").gameObject.SetActive(true);
            }
        }

        if (SceneManager.GetActiveScene().name == "RockPool")
        {
            if (hasStick)
            {
                GameObject.Find("Stick").transform.Find("StickPrefab").gameObject.SetActive(true);
                GameObject.Find("Stick").GetComponent<Caster>().enabled = true;
            }
        }
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        if(curShells == winShells)
            SceneManager.LoadScene("End");
    }
}
