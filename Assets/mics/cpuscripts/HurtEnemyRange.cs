using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HurtEnemyRange : MonoBehaviour
{
    public int damageToGive;
    public GameObject damageFx;
    public Transform hitPoint;
    public GameObject damageText;
	public GameObject asdf;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ESDEnemies" || other.gameObject.tag == "OfficeEnemies" || other.gameObject.tag == "FireEnemies" || other.gameObject.tag == "DustEnemies" || other.gameObject.tag == "Boss")
        {

			//GetComponent<AudioSource> ().PlayOneShot ( GetComponent<AudioSource> ().clip , 1.0f );
            other.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(damageToGive);

			GameObject.Instantiate (asdf);

            
            Destroy(transform.parent.gameObject);
        }
        if (other.gameObject.CompareTag("Untagged"))
            Destroy(transform.parent.gameObject);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        

    }
}
