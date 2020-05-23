using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;

public class ReStart : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 oldPos;
    Vector3 euler0;
    public Button b1;

    public GameObject[] pins = new GameObject[9];
    Vector3[] positionArray = new Vector3[9];
    Vector3[] rotationArray = new Vector3[9];

    void Start() {
        oldPos = transform.position;
        euler0= transform.eulerAngles;

        for (int i = 0; i < 9; i++)
        {
            positionArray[i]=pins[i].transform.position;
            rotationArray[i] = pins[i].transform.eulerAngles;
        }

    }
    //public GameObject gameObjectToMove;
    public void RestartGame()
    {
        //SceneManager.LoadScene("SampleScene");
        transform.position = oldPos;
        transform.eulerAngles = euler0;
        transform.Translate(Vector3.forward * Time.deltaTime  * 0, Space.World);
        b1.GetComponentInChildren<Text>().text = "Score";

        for (int i = 0; i < 9; i++)
        {
             pins[i].transform.position = positionArray[i];
             pins[i].transform.eulerAngles = rotationArray[i];
        }

    }
}
