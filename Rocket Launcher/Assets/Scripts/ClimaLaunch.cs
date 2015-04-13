using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ClimaLaunch : MonoBehaviour {

	public GameObject MaximoViento;
	public GameObject Temperatura;
	public GameObject Precipitacion;
	public GameObject Trueno;
	
	// Use this for initialization
	void Start () {
		int Temperatura1 = Random.Range(38,102);
		int MViento = Random.Range (2,7);
		int Nubes = Random.Range (0, 100);
		int Truenos = Random.Range (0, 100);
		if (Nubes > 14)
		{
			Precipitacion.GetComponent<Text> ().text = "NO";
		} 
		else 
		{
			Precipitacion.GetComponent<Text> ().text = "YES";
		}

		if (Truenos > 3) {

						Trueno.GetComponent<Text>().text = "NO";
				}
		else {
			Trueno.GetComponent<Text>().text = "YES";
		}


		MaximoViento.GetComponent<Text>().text=MViento.ToString()+" m/s";
		Temperatura.GetComponent<Text>().text=Temperatura1.ToString()+" °F";

	
	}
}
