using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XAxisTranslate : MonoBehaviour
{
    // Start is called before the first frame update
    

    [Range(0.0f, 10.0f)]
    public float speed = 0.03f;

    [Range(-10.0f, 0.0f)] public float min = -5;
    [Range(0.0f, 10.0f)] public float max = 5;
    private bool fw = true;
    //private GameObject parent;
    void Start()
    {
        //parent = GameObject.Find("Translation");
    }

    // Update is called once per frame
    void Update()
    {
        if(fw) {
            this.transform.localPosition += new Vector3(speed, 0.0f, 0.0f);
            if(this.transform.position.x - this.transform.parent.transform.position.x > max) {
                fw = false;
            }
        } else {
            this.transform.localPosition += new Vector3(-speed, 0.0f, 0.0f);
            if(this.transform.position.x - this.transform.parent.transform.position.x < min) {
                fw = true;
            }
        }
        
        
    }
}
