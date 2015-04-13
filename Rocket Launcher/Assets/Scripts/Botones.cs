using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Botones : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
	
	}

	public void start_level()
	{
		Application.LoadLevel("Lanzamiento");
	}

	public void info_level()
	{
		Application.LoadLevel("Info");
	}

	public void info_weather()
	{
		Application.LoadLevel("Info_weather");
	}

	public void info_fuel()
	{
		Application.LoadLevel("info_fuel");
	}

	public void info_crafts()
	{
		Application.LoadLevel("Info_crafts");
	}

	public void back_inicio()
	{
		Application.LoadLevel("Menu");
	}

	public void tanking_level()
	{
		Application.LoadLevel("cabo cañaveral tanke");
	}
	// Update is called once per frame
	void Update () {

	}
}
