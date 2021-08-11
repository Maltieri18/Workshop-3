using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMode : MonoBehaviour
{
    // Start is called before the first frame update
    private bool cont = true;
    public float speed = 0.1f;
    public float spinSpeed = 100.0f;
    void Start()
    {
        gameObject.GetComponent<Renderer>().material.color = Color.red;
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

        if(!cont) {
            speed *= 1.005f;
            if(!Input.anyKey) {
                speed = 0.1f;
            }
        }

        if(Input.GetKeyDown(KeyCode.E)) {
            if(cont) {
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                cont = !cont;
            } else {
                gameObject.GetComponent<Renderer>().material.color = Color.red;
                cont = !cont;
            }
        }
    }
}