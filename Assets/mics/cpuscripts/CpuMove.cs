using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CpuMove : MonoBehaviour {

    public enum CpuMovement
    {
        top,right,bottom,left
    }

    public CpuMovement cpuMovement; 


    CharacterController cc;
    public float speed = 3.5f;
	// Use this for initialization
	void Start () {
        cc = GetComponent<CharacterController>();
       // Invoke("destroyProjectile",1.5f);
	}
	
	// Update is called once per frame
	void Update () {
        if(cpuMovement.Equals(CpuMovement.right))
        cc.Move(Vector3.right * Time.deltaTime * speed);
        if (cpuMovement.Equals(CpuMovement.top))
            cc.Move(Vector3.up * Time.deltaTime * speed);
        if (cpuMovement.Equals(CpuMovement.left))
            cc.Move(-Vector3.right * Time.deltaTime * speed);
        if (cpuMovement.Equals(CpuMovement.bottom))
            cc.Move(-Vector3.up * Time.deltaTime * speed);
    }

    public void destroyProjectile()
    {
        Destroy(this.gameObject.transform.parent.gameObject);
    }
}
