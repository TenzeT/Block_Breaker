using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    public bool autoPlay = false;
    private Ball ball;

    // Use this for initialization
    void Start()
    {
        ball = GameObject.FindObjectOfType<Ball>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!autoPlay)
        {
            MoveWithMouse();
        }
        else
        {
            AutoPlay();
        }
    }

    void MoveWithMouse()
    {
        Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, this.transform.position.z); // f = float, keep y pos, keep depth
        float mousePosInBlocks = Input.mousePosition.x / Screen.width * 16; // Because 16 units across
        paddlePos.x = Mathf.Clamp(mousePosInBlocks, .5f, 15.5f); // Move paddle with mouse position, clamp setting min and max values
        this.transform.position = paddlePos;
    }

    // Have paddle follow balls X pos for automation
    void AutoPlay()
    {
        Vector3 paddlePos = new Vector3(0.5f, this.transform.position.y, this.transform.position.z);
        Vector3 ballPos = ball.transform.position;
        paddlePos.x = Mathf.Clamp(ballPos.x, .5f, 15.5f);
        this.transform.position = paddlePos;
    }
}
