using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FigureEight : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(0.0f, 1000.0f)] public float speed = 100.0f;
    private Vector3 startPos;
    private Vector3 anchor;
    private int times = 0;
    void Start()
    {
        startPos = new Vector3(0.0f, 0.0f, 0.0f);
        anchor = startPos + new Vector3(5.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {   
        //Debug.Log(startPos.ToString() + "   " + transform.position.ToString());
        transform.RotateAround(anchor, Vector3.up, speed * Time.deltaTime);
        if(Mathf.FloorToInt(transform.position.x) == startPos.x && Mathf.FloorToInt(transform.position.z) == startPos.x) {
            Debug.Log("We hit starting pos " + times.ToString() + "times!");
            times += 1;
        }
    }
}
