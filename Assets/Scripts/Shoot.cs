using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject ball;
    private int speed=0;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * 3.5f*speed, Space.World);
        if (transform.position.y < -2) {
        transform.position = new Vector3(0, -2, 0);
        transform.eulerAngles = new Vector3(0, 0, 0);
        speed = 0;
        }    
    }

    public void ShootPin()
    {
        speed = 1;
    }
}
