using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
 
    // Start is called before the first frame update
    public void moveLeft() {
        transform.Translate(Vector3.left * Time.deltaTime*2, Space.World);
    }
}
