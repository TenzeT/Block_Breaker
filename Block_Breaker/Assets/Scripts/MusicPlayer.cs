using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    static MusicPlayer instance = null;

    void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            GameObject.DontDestroyOnLoad(gameObject); // gameObject is the Music Player instance
        }
    }
    // Use this for initialization
    void Start()
    {
        // Moved this code to Awake() to avoid multiple Music Player creations
    }

    // Update is called once per frame
    void Update()
    {

    }
}
