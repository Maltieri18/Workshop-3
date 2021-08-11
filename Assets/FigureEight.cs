using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FigureEight : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(0.0f, 1000.0f)] public float speed = 100.0f;
    private Vector3 startPos;
    private Vector3 anchor;
    void Start()
    {
        startPos = transform.parent.position;
        anchor = startPos + new Vector3(5.0f, 0.0f, 0.0f); //radius is the norm
    }

    // Update is called once per frame
    void Update()
    {   
        //Debug.Log(startPos.ToString() + "   " + transform.position.ToString());
        transform.RotateAround(anchor, Vector3.up, speed * Time.deltaTime);
        if(Mathf.Round(transform.position.x) == startPos.x && Mathf.Round(transform.position.z) == startPos.z) {
            anchor *= -1;
        }
    }
}
