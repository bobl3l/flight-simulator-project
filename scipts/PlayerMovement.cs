 using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	// This is a reference to the Rigidbody component called "rb"
	public Rigidbody rb;
	public SpawnManager spawnManager;
	public float forwardForce = 2000f;	// Variable that determines the forward force
	public float sidewaysForce = 500f;  // Variable that determines the sideways force
	public float upwardForce = 500f;
	public float turn;
	public float turnback;

	// We marked this as "Fixed"Update because we
	// are using it to mess with physics.
	void FixedUpdate ()
	{
		// Add a forward force //
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);

		if (Input.GetKey("d"))	// If the player is pressing the "d" key
		{
			// Add a force to the right
			rb.AddForce(sidewaysForce, 0, 0);
			rb.transform.Rotate(0,0,turn);

			
		}

		if (Input.GetKey("a"))  // If the player is pressing the "a" key
		{
			// Add a force to the left
			rb.AddForce(-sidewaysForce, 0, 0);
			rb.transform.Rotate(0,0,-turn);

		}

		if (Input.GetKey("w"))  // If the player is pressing the "a" key
		{
			// Add a force to the left
			rb.AddForce(0, upwardForce, 0);
		}

		if (Input.GetKey("s"))  // If the player is pressing the "a" key
		{
			// Add a force to the left
			rb.AddForce(0, -upwardForce, 0);
			// hello
		}

		if (gameObject.transform.rotation.z>0) {
				rb.transform.Rotate(0,0,-turnback);
			} else {
				rb.transform.Rotate(0,0,turnback);
			}
	}
	private void OnTriggerEnter(Collider other)
	{
		spawnManager.SpawnTriggerEntered();
	}
}
