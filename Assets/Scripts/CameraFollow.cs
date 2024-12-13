using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Vector3 camFollow;
    private Transform ball, win;

    void Start()
    {
        ball = FindObjectOfType<Ball>().transform;
    }

    // Update is called once per frame
    void Update()
    {
     if(win ==  null)
        {
            win = GameObject.Find("Win(Clone)").GetComponent<Transform>();
        }   
      if(transform.position.y > ball.transform.position.y && transform.position.y > win.position.y + 4f)
        {
            camFollow = new Vector3 (transform.position.x,ball.position.y,transform.position.z);
        }

        transform.position = new Vector3(transform.position.x, camFollow.y, -5);
    }
}
