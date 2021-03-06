﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    [SerializeField] GameObject doorTwo;
    [SerializeField] float endDelay = 1f;

    GameObject cam;

    // Start is called before the first frame update
    void Start()
    {
        if (cam == null)
            cam = Camera.main.gameObject;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            BeginRewind();
    }

    private void BeginRewind()
    {
        if (doorTwo != null)
        {
            cam.GetComponent<CamMovement>().Rewind(endDelay);
            doorTwo.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
