using UnityEngine;
using System.Collections;

public class ClickBall : MonoBehaviour {

    public Sprite kazalli;
    public Sprite mezoolu;
    public Sprite uva;
    public Sprite ankh;
    NewBehaviourScript nb;
    int bonustipe = -1;

    // Use this for initialization
	void Start () {
         nb = GameObject.FindGameObjectWithTag("Player").GetComponentInChildren<NewBehaviourScript>();
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown() 
    {
        if (bonustipe != -1) 
        {
            //hacer la cosa
            Destroy(this.gameObject);
        }
        int isbonus = Random.Range(0, 100);
        if (isbonus <= 42) 
        {
            Destroy(this.gameObject);
            nb.current--;
        }

        else 
        {
            bonustipe = Random.Range(0,5);
            switch (bonustipe)
            {
                case 1:
                    {
                        GetComponent<SpriteRenderer>().sprite = kazalli;
                        return;
                    }
                case 2: 
                    {
                        GetComponent<SpriteRenderer>().sprite = mezoolu;
                        return;
                    }
                case 3: 
                    {
                        GetComponent<SpriteRenderer>().sprite = uva;
                        return;
                    }
                case 4: 
                    {
                        GetComponent<SpriteRenderer>().sprite = ankh;
                        return;
                    }
            }
        }
        
//        GetComponent<SpriteRenderer>().sprite = sprite;
        //Destroy(this.gameObject);
    }
}
