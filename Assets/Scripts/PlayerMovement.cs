using UnityEngine;
public class PlayerMovement : MonoBehaviour {
	public Rigidbody rb;
	public float forwardForce = 2000f;
	public float directionalForce = 500;
	
	// Update is called once per frame
	void FixedUpdate () {
		
		rb.AddForce (0, 0, forwardForce * Time.deltaTime);

		if( Input.GetKey("d"))
		{
			rb.AddForce (directionalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if( Input.GetKey("a"))
		{
			rb.AddForce (-directionalForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if( Input.GetKey("w"))
		{
			rb.AddForce (0, 0, directionalForce * Time.deltaTime, ForceMode.VelocityChange);
		}

		if (rb.position.y < -1f) {
			FindObjectOfType<GameManager>().EndGame();
		}

}
}