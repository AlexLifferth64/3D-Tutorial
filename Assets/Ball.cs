using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private bool isRed = false;
    private bool is8Ball = false;
    private bool isCueBall = false;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if(rb.velocity.y > 0)
        {
            Vector3 newVelocity = rb.velocity;
            newVelocity.y = 0;
            rb.velocity = newVelocity;
        }
    }

    public bool IsBallRed()
    {
        return isRed;
    }

    public bool IsCueBall()
    {
        return isCueBall;
    }

    public bool IsEightBall()
    {
        return is8Ball;
    }

    public void BallSetup(bool red)
    {
        isRed = red;
        if(isRed)
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        else
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
    }

    public void MakeCueBall()
    {
        isCueBall = true;
        GameObject.Find("GameManager").GetComponent<GameManager>().cueBall = gameObject;
    }

    public void MakeEightBall()
    {
        is8Ball = true;
        GetComponent<Renderer>().material.color = Color.black;
    }
}
