using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charactermotor : MonoBehaviour {

    //animation perso
    Animation animations;

    //vitesse de déplacement
    public float WalkSpeed;
    public float runspeed;
    public float turnspeed;

    //Inputs
    public string inputfront;
    public string inputback;
    public string inputleft;
    public string inputright;

    public Vector3 jumpSpeed;
    CapsuleCollider playerCollider;

	
	void Start () {
        animations = gameObject.GetComponent<Animation>();
        playerCollider = gameObject.GetComponent<CapsuleCollider>();
		
	}
	
	// Update is called once per frame
	void Update () {

        // si on avance
        if(Input.GetKey(inputfront))
        {
            transform.Translate(0, 0, WalkSpeed * Time.deltaTime );
            animations.Play("walk");
        }
        //si on recul
        if (Input.GetKey(inputback))
        {
            transform.Translate(0, 0, -(WalkSpeed/2) * Time.deltaTime);
            animations.Play("walk");
        }
         //rotation à gauche
        if (Input.GetKey(inputleft))
        {
            transform.Translate(0, -turnspeed * Time.deltaTime, 0); 
        }
        //rotation à droite
        if (Input.GetKey(inputright))
        {
            transform.Translate(0, turnspeed * Time.deltaTime, 0);
        }
    }
}
