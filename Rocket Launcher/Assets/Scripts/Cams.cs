using UnityEngine;
using System.Collections;

public class Cams : MonoBehaviour {

	public GameObject camera1;
	public GameObject camera2;
	public GameObject camera3;
	public GameObject camera4;
	public Camera cameral = new Camera();
	public Camera camerall = new Camera();
	public Camera cameralll = new Camera();
	public Camera cameralv = new Camera();

	// Use this for initialization
	void Start () {

		camera1.SetActive (true);
		camera2.SetActive (true);
		camera3.SetActive (true);
		camera4.SetActive (true);

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Alpha1)) 
		{
			camera1.SetActive(true);
			camera2.SetActive(false);
			camera3.SetActive(false);
			camera4.SetActive(false);
		}

		if (Input.GetKeyDown(KeyCode.Alpha2)) 
		{
			camera1.SetActive(false);
			camera2.SetActive(true);
			camera3.SetActive(false);
			camera4.SetActive(false);
		}

		if (Input.GetKeyDown(KeyCode.Alpha3)) 
		{
			camera1.SetActive(false);
			camera2.SetActive(false);
			camera3.SetActive(true);
			camera4.SetActive(false);
		}

		if (Input.GetKeyDown(KeyCode.Alpha4)) 
		{
			camera1.SetActive(false);
			camera2.SetActive(false);
			camera3.SetActive(false);
			camera4.SetActive(true);
		}

		if (Input.GetButtonDown ("Fire1")) 
		{

		}

	}
}
