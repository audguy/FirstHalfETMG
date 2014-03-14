using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

	public GameObject player;
	private Vector3 Offset;
	private float chngHdng;

	// Use this for initialization
	void Start () {
		Offset = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position = player.transform.position + Offset;
		transform.LookAt (player.transform.position, Vector3.up);
		transform.RotateAround (player.transform.position, Vector3.up, chngHdng);



	
	}

	void OnGUI()
	{
		if (GUI.RepeatButton (new Rect (5, 5, (Screen.width / 10) + 5, Screen.height - 10), "<") == true)
			chngHdng += -1.0f;

		if (GUI.RepeatButton (new Rect (Screen.width - ((Screen.width / 10)+5), 5, Screen.width - 5, Screen.height - 10), ">") == true)
			chngHdng += 1.0f;

	}
}
