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


	
		transform.position = player.transform.position + Offset;
		transform.LookAt (player.transform.position, Vector3.up);
		transform.RotateAround (player.transform.position, Vector3.up, chngHdng);

		valu.text = player.transform.position.ToString();

		//chngHdng = 0.0f;
	}

	void OnGUI()
	{
		if (GUI.RepeatButton (new Rect (5, 5, (Screen.width / 10) + 5, Screen.height - 10), "<") == true)
						chngHdng += -1.0f;

	}
}
