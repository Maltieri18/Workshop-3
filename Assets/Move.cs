using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float spinSpeed = 10.0f;
    public float speed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localRotation *= Quaternion.AngleAxis(Time.deltaTime * spinSpeed, new Vector3(1.0f, 0.0f, 0.0f));
        if(Input.GetKey(KeyCode.UpArrow)) {
            transform.position += new Vector3(0.0f, 0.0f, speed);
        } else if(Input.GetKey(KeyCode.DownArrow)) {
            transform.position += new Vector3(0.0f, 0.0f, -speed);
        } else if(Input.GetKey(KeyCode.LeftArrow)) {
            transform.position += new Vector3(-speed, 0.0f, 0.0f);
        } else if(Input.GetKey(KeyCode.RightArrow)) {
            transform.position += new Vector3(speed, 0.0f, 0.0f);
        } 
    }
}
