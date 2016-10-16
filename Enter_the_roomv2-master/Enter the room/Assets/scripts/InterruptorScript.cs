using UnityEngine;
using System.Collections;

public class InterruptorScript : MonoBehaviour {

    [SerializeField]

    GameObject Interruptor;

    public bool IsActivated = false;

    void OnTriggerEnter(Collider Other)
    {
        
         IsActivated = true;
    }

    void OnTriggerExit(Collider Other)
    {
        if(Other.gameObject.layer == 8)
        {
            
            IsActivated = false;
        }
       
    }
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
