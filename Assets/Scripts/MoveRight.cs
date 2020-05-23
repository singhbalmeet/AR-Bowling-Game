using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    // Start is called before the first frame update
    public void moveRight()
    {
        transform.Translate(Vector3.right * Time.deltaTime*2, Space.World);
    }
}
