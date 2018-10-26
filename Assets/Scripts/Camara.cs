using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour {
    public GameObject Nave;
    public float rapidez = 1f;
    public float speed = 0.5f;
    public Vector3 offset;
    // Use this for initialization
    void Start () {
        offset = transform.position - Nave.transform.position;
    }
	
	// Update is called once per frame
	void LateUpdate () {
        float vertical = Input.GetAxis("Horizontal") * speed;
        gameObject.transform.Translate(new Vector3(vertical * rapidez, 0, 0));
        transform.position = Nave.transform.position + offset;
    }
}
