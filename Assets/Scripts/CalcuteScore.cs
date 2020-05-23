using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEditor;

public class CalcuteScore : MonoBehaviour
{
    public GameObject[] pins=new GameObject[9];
    int num = 0;
    public Button b1;
    Vector3 euler0;

    // Start is called before the first frame update
    public void CalcuteScores()
    {
        foreach (GameObject obj in pins)
        {
            //var z = UnityEditor.TransformUtils.GetInspectorRotation(obj.transform).z;
            //var x = UnityEditor.TransformUtils.GetInspectorRotation(obj.transform).x;
            //var y = UnityEditor.TransformUtils.GetInspectorRotation(obj.transform).y;
            euler0 = obj.transform.localEulerAngles;
         
            float result = WrapAngle(euler0.x) + WrapAngle(euler0.y) + WrapAngle(euler0.z);
            //Debug.Log("result: " + result);
            //var result = x + y+z;
            if (result > 30.0 || result < -30.0)
            {
                num = num + 1;
            }
        };
       // Debug.Log("num: " + num);
        b1.GetComponentInChildren<Text>().text  = num.ToString();
    }
    private static float WrapAngle(float angle)
    {
        angle %= 360;
        if (angle > 180)
            return angle - 360;
        return angle;
    }
}
