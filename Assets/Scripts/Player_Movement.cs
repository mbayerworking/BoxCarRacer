using UnityEngine;

public class Player_Movement : MonoBehaviour {

    public Rigidbody rigidbody;

    public float forwardForce = 500f;
    public float sidewaysForce = 500f;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
    // Use FixedUpdate to calculate physics
	void FixedUpdate () {
        // Add a forward force  
        rigidbody.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rigidbody.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rigidbody.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
