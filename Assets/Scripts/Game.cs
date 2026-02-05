using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour {

    public int hSpeed;
    public int vSpeed;
    public Rigidbody cannonBall;


	
	void Update () {

        float h = Input.GetAxis("Horizontal");
        transform.Translate(h * Time.deltaTime * hSpeed, 0, 0);

        float v = Input.GetAxis("Vertical");
        transform.Rotate(v * Time.deltaTime * vSpeed, 0, 0);

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(cannonBall, transform.position, transform.rotation);
        }
    }
}
