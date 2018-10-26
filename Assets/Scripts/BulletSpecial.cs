using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpecial : MonoBehaviour {
    public float Speed = 10;
    public GameObject BulletSp;
    // Use this for initialization
    void Start()
    {
        BulletSp.GetComponent<Renderer>().material.color = Color.red;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * Speed);
    }
}
