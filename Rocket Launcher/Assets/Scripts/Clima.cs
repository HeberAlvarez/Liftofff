using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Clima : MonoBehaviour {
	
	public GameObject PromedioTemperatura;
	public GameObject MinimaTemperatura;
	public GameObject MaximoViento;
	public GameObject ProbabilidadTormenta;
	public GameObject Errores;
	
	// Use this for initialization
	void Start () {
		int Temperatura1 = Random.Range(38,102);
		int Temperatura2 = Random.Range (38, 102);
		int MViento = Random.Range (2,7);
		int PorcentajeTormenta = Random.Range (0 , 100);
		MaximoViento.GetComponent<Text> ().text =MViento.ToString()+" m/s";
		if (PorcentajeTormenta > 3) {
			ProbabilidadTormenta.GetComponent<Text>().text="No";	
		} 
		else {
			ProbabilidadTormenta.GetComponent<Text>().text="Yes";
		}
		
		if(Temperatura2<=Temperatura1){
			
			PromedioTemperatura.GetComponent<Text>().text =Temperatura1.ToString()+" °F";
			MinimaTemperatura.GetComponent<Text>().text=Temperatura2.ToString()+" °F";
		}
		else{
			MinimaTemperatura.GetComponent<Text>().text=Temperatura1.ToString()+" °F";
			PromedioTemperatura.GetComponent<Text>().text=Temperatura2.ToString()+" °F";
			
		}
		int ContadorDeMalasDecisiones = 0;
		string PromedioT = PromedioTemperatura.GetComponent<Text> ().text;
		string MinT = MinimaTemperatura.GetComponent<Text>().text;	
		
		if(int.Parse(PromedioT)<41)
		{
			ContadorDeMalasDecisiones=ContadorDeMalasDecisiones+1;						
		}
		if(int.Parse(MinT)<33)
		{
			ContadorDeMalasDecisiones=ContadorDeMalasDecisiones+1;						
		}
		if (ProbabilidadTormenta.GetComponent<Text> ().text.Equals ("Yes")) {
			
			ContadorDeMalasDecisiones=ContadorDeMalasDecisiones+1;
		}
		
		Errores.GetComponent<Text>().text=ContadorDeMalasDecisiones.ToString();
		
		
		
	}
}
