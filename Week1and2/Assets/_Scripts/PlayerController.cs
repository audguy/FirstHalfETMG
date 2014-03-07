using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float Scale=10;
	public GUIText Accel;
	private bool isEnabled;
	void Start()
	{
		isEnabled = Input.location.isEnabledByUser;
		Input.location.Start ();

		//LocationService ls = new LocationService ();
		//ls.Start ();
	}
	void FixedUpdate()
	{/*
		Vector3 acceleration = Vector3.zero;
		int i = 0;
		while (i < Input.accelerationEventCount) {
			AccelerationEvent accEvent = Input.GetAccelerationEvent(i);
			acceleration += accEvent.acceleration * accEvent.deltaTime;
			++i;
		}
		//float moveH = Input.GetAxis ("Horizontal");
		//float moveV = Input.GetAxis ("Vertical");
		Vector3 scl = new Vector3 (Scale, Scale, Scale);

		//acceleration.y = 0.0f;
		//rigidbody.AddForce (acceleration *Scale,ForceMode.VelocityChange);
		rigidbody.AddTorque (acceleration*Scale,ForceMode.VelocityChange);
		*/
	

			Vector3 dir = Vector3.zero;
			dir.z = Input.acceleration.y;
			dir.x = Input.acceleration.x;
		dir.y = 0;//Input.acceleration.z;
			//if (dir.sqrMagnitude > 1)
			//	dir.Normalize();

		LocationInfo li = new LocationInfo ();
		if (isEnabled && Input.location.status == LocationServiceStatus.Running)
			Accel.text = dir.ToString () + "\nLat:" + Input.location.lastData.latitude + "\nLon:" + Input.location.lastData.longitude + "\nAlt:" + Input.location.lastData.altitude;
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
	