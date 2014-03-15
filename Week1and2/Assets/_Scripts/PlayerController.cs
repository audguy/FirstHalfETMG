using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float Scale=10;
	public GUIText Accel;
	public GameObject camera;
	private bool isEnabled;
	private bool wentdown;
	void Start()
	{
		isEnabled = Input.location.isEnabledByUser;
		Input.location.Start ();
		wentdown = false;

	}
	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Escape)){Application.Quit();}

		if (rigidbody.transform.position.y < -20.0f) {
			wentdown = true;
						Application.LoadLevel ("Win");
				}
	}
	void FixedUpdate()
	{

			Vector3 dir = Vector3.zero;
			dir.z = Input.acceleration.y;
			dir.x = Input.acceleration.x;
		dir.y = 0;//Input.acceleration.z;
			//if (dir.sqrMagnitude > 1)
			//	dir.Normalize();
		Quaternion rotation = Quaternion.Euler (camera.transform.localRotation.eulerAngles);
		rotation.x = 0.0f;
		dir = rotation * dir;

		if (isEnabled && Input.location.status == LocationServiceStatus.Running)
			Accel.text = dir.ToString () + "\nLat:" + Input.location.lastData.latitude + "\nLon:" + Input.location.lastData.longitude + "\nAlt:" + Input.location.lastData.altitude  + "\nPos: " + transform.position.ToString()+ "\nWentDown: "+ wentdown.ToString();
				else if (Input.location.status == LocationServiceStatus.Initializing)
						Accel.text = dir.ToString () + "\nLoc data Init";
		else if (Input.location.status == LocationServiceStatus.Failed)
			Accel.text = dir.ToString () + "\nLoc data Failed";
		else if (Input.location.status == LocationServiceStatus.Stopped)
			Accel.text = dir.ToString () + "\nLoc data Stopped";
		else
			Accel.text = dir.ToString () + "\nLoc data not enabled";
		//dir *= Time.deltaTime;
		rigidbody.AddForce (dir,ForceMode.VelocityChange);
			//transform.Translate(dir * Scale);
		}
	}
	