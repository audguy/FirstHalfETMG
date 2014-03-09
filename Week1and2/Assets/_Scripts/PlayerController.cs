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
	{

			Vector3 dir = Vector3.zero;
			dir.z = Input.acceleration.y;
			dir.x = Input.acceleration.x;
		dir.y = 0;//Input.acceleration.z;
			//if (dir.sqrMagnitude > 1)
			//	dir.Normalize();

		LocationInfo li = new LocationInfo ();
		if (isEnabled && Input.location.status == LocationServiceStatus.Running)
			Accel.text = dir.ToString () + "\nLat:" + Input.location.lastData.latitude + "\nLon:" + Input.location.lastData.longitude + "\nAlt:" + Input.location.lastData.altitude + "\nHeding: " + Input.compass.trueHeading;
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
	