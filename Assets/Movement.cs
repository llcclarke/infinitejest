using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Movement : MonoBehaviour
{
    public float speed = 10;
//	public float// moves 10 units every second
//	public GameObject player;

    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
		Vector3 temp = transform.position; // copy to an auxiliary variable...
		temp.y = 3.0f; // modify the component you want in the variable...
		transform.position = temp;
         transform.position = transform.position + Camera.main.transform.forward * speed * Time.deltaTime;

//        transform.Translate(Camera.main.transform.forward * Time.deltaTime * speed, Space.World);
    }
}
