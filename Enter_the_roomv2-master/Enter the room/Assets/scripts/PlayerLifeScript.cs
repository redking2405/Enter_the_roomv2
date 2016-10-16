using UnityEngine;
using System.Collections;

public class PlayerLifeScript : MonoBehaviour {

    private int LifeMax = 3;

    
        public int life;
	// Use this for initialization
	void Start () {

        life = LifeMax;
	
	}
	
	// Update is called once per frame
	void Update () {

        if (life == 0)
        {
            Debug.Log("Je suis Mort");
        }
	
	}
}
