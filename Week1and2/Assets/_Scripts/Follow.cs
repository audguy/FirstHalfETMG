using UnityEngine;
using System.Collections;

public class Follow : MonoBehaviour {

	public GameObject player;
	public GUIText valu;
	private Vector3 Offset;
	private float chngHdng;

	// Use this for initialization
	void Start () {
		Offset = transform.position;
	
	}
	
	// Update is called once per frame
	void Update () {

		//
		transform.position = player.transform.position;

		transform.rotation.Set (transform.rotation.x, 0.0f, transform.rotation.z, 0.0f);
		//transform.RotateAround(player.rigidbody.position, Vector3.up, chngHdng);
		transform.position.Set(player.transform.position.x + Offset.x,player.transform.position.y + Offset.y,player.transform.position.z + Offset.z);
		valu.text = player.transform.position.ToString();

		chngHdng = 0.0f;
	}

	void OnGUI()
	{
		if (GUI.RepeatButton (new Rect (5, 5, (Screen.width / 10) + 5, Screen.height - 10), "<") == true)
						chngHdng = -1.0f;

	}
}
