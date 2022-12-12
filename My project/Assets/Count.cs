using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CountManager : MonoBehaviour
{
    static int Count = 0; 

    private TextMeshPro CountText;


    // Start is called before the first frame update
    void Start()
    {
        GameObject SphereGameObject = GameObject.Find("Count");

        CountText = SphereGameObject.GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        CountText.text = "Ball Count: " + Count;
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Sphere")
        {
            Count++;
        }
    }
        public virtual void CollideWithSphere(GameObject Sphere)
    {
        Debug.Log("Base Collision Manager Function");
    }
}
