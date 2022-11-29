using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour {
    private float length, startpos;
    public GameObject cam;
    public float parallaxEffect;

    void Start () {
        startpos = transform.position.x; //start pos of sprite
        length = GetComponent<SpriteRenderer>().bounds.size.x; //size of the sprite
    }
    void FixedUpdate () {
        float temp = (cam.transform.position.x * (1 - parallaxEffect)); //how far we moved relative to camera.. 1- parallax is rel to camera
        float dist = (cam.transform.position.x * parallaxEffect);//how far we travelled
        //transform the current parallax 
        transform.position= new Vector3(startpos + dist, transform.position.y, transform.position.z);
        if (temp > (startpos + length)) 
            startpos += length;
        else if (temp < (startpos - length))
            startpos -= length;

    }

}