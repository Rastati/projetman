using UnityEngine;
using System.Collections;

public class moveOrb : MonoBehaviour {


    float time;
    public float Timerinterval = 5f;
    float tick;

	public KeyCode moveL;
	public KeyCode moveR;

	public float horizVel = 0;
	public int laneNum=2;
	public string controlLocked = "n";

    private GameObject star;

   

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

       


		GetComponent<Rigidbody> ().velocity = new Vector3 (horizVel, 0, 8);

		if ((Input.GetKeyDown (moveL)) &&  (laneNum>1) && (controlLocked == "n"))
		{
			horizVel = -2;
			StartCoroutine (stopSlide ());
			laneNum -=1;
			controlLocked = "y";
		}

		if ((Input.GetKeyDown (moveR)) && (laneNum<3) && (controlLocked == "n"))
		{
			horizVel = 2;
			StartCoroutine (stopSlide ());
			laneNum +=1;
			controlLocked = "y";
		}
	}
      
    void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "stars")
        {
            other.gameObject.SetActive(false);

            if (other.gameObject.name == "Star(1)")
            {
                star = GameObject.Find("/Canvas/StarsContainer/Star(1)/Star");
            }
            else if (other.gameObject.name == "Star(2)")
            {
                star = GameObject.Find("/Canvas/StarsContainer/Star(2)/Star");
            }
            else if (other.gameObject.name == "Star(3)")
            {
                star = GameObject.Find("/Canvas/StarsContainer/Star(3)/Star");
            }

            star.SetActive(true);

        }
        else if (other.gameObject.tag == "lethal")
        {
            Destroy(gameObject);
            moveCamera.speed = 0;

        }

    }

    IEnumerator stopSlide()
	{
		yield return new WaitForSeconds (.5f);
		horizVel = 0;
		controlLocked = "n";
	}
}
 