using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement2 : MonoBehaviour
{
    public float speed = 10; // moves 10 units every second

    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
			Debug.Log("2");
        transform.Translate(transform.forward * Time.deltaTime * speed, Space.World);
    }
}
