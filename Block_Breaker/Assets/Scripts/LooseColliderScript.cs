using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseColliderScript : MonoBehaviour
{
    public LevelManager levelManager; // Expose level manager

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("Trigger");
        levelManager.LoadLevel("Lose_Screen");
    }

    // Not used here
    private void OnCollisionEnter(Collision collision)
    {
        print("Collision");
    }
}
