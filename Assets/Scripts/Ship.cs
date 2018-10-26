using UnityEngine;
using System.Collections;

public class Ship : MonoBehaviour
{
    public int life = 100;
    public int score = 0; 
    public bool damage = false;

    public Transform SpawnBulletPosition;

    public Transform Bullet;
    public Transform BulletSpecial;

    public GameObject ShipMesh;



     void OnGUI()
    {
        GUILayout.Label("LifePlayer:" + life);
        GUILayout.Label("score:" + score);
    }


    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        
        if (Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
        else if(Input.GetButtonDown("Fire2") || Input.GetKeyDown(KeyCode.C))
        {
            ShootSpecial();
        }
 
    }

    void Shoot()
    {
        Instantiate(Bullet, SpawnBulletPosition.position, Quaternion.identity);
     
    }
    void ShootSpecial()
    {
        Instantiate(BulletSpecial, SpawnBulletPosition.position, Quaternion.identity);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Metheorite")
        {

            Damaged();
        }
    }

    void Damaged()
    {
        if (damage)
        {
       
            return;
        }
        damage = true;
        ShipMesh.GetComponent<Renderer>().material.color = Color.red;
        Invoke("NotDamaged", 2);
        life = life-5 ;
        //score = score + 100;
    }

    void NotDamaged()
    {
        score++;
        damage = false;
        ShipMesh.GetComponent<Renderer>().material.color = Color.white;
    }

}
