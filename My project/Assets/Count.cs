using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallCount : MonoBehaviour
{
    static int Count = 0;

    private TextMeshPro Count;

    // Start is called before the first frame update
    void Start()
    {
        GameObject Cube = GameObject.Find("Cube");

        Count = Cube.GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        Count.text = "Ball Count : " + ballCollisionCount;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Cube")
        {
            ballCollisionCount++;
        }

        // Do something comparable for when collisions occur between a ball and a wall.
        // Hint, the walls have the tag "Wall".
    }
}
