using UnityEngine;
using System.Collections;

public class Colision : MonoBehaviour {

	// Use this for initialization
    NewBehaviourScript nb;
	void Start () {

        nb = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<NewBehaviourScript>();
	}

    public GameObject bar;
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D coll)
    {
        Destroy(coll.gameObject);
        Vector3 v3Pos = bar.transform.position;
        v3Pos.y += 0.226f;
        if (v3Pos.y >= -5f) 
        {
            Object[] objects = FindObjectsOfType(coll.gameObject.GetType());
            foreach (GameObject go in objects)
            {
                if(go.name.Equals("Medal"))
                    Destroy(go.gameObject);
                nb.current = -1;
            }
        }
        else 
        {
            bar.transform.position = v3Pos;
            nb.current--;
        }
        Debug.Log(v3Pos.y);
        
    }


}
