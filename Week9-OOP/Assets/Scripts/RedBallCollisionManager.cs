using System;
using UnityEngine;

public class RedBallCollisionManager : BallCollisionManager
{
    public override void CollideWithBall(GameObject Otherball)
    {
        Debug.Log("Red Ball Collision Manager Function");

        // Homework: Do something interesting here
        // Should destroy Green ball
        if(Otherball.GetComponent<GreenBallCollisionManager>() != null)
        {
            Destroy(Otherball);
        }

    }
}

