using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

    int contador = 0;
    public int dificultad = -1;
    public GameObject medall;
    public int current = 0;
    // Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (current > 5) 
        {
            return;
        }
        if (current == -1)
            return;
        if (dificultad > 0 && contador == dificultad)
        {
            int x = Random.Range(-3, 3);
            int y = 6;
            Vector3 v3 = new Vector3(x, y);
            Instantiate(medall, v3, transform.rotation);
            contador = 0;
            current++;
            Debug.Log("creado un objeto " + current);
            return;
        }
        contador++;
	}
}
