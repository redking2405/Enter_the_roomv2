using UnityEngine;
using System.Collections;

public class Room2Script : MonoBehaviour {

    [SerializeField]

    GameObject Teleporter1;

    [SerializeField]

    GameObject Teleporter2;

    [SerializeField]

    GameObject Teleporter3;

    [SerializeField]

    GameObject Interruptor1;

    [SerializeField]

    GameObject Interruptor2;

    [SerializeField]

    GameObject Interruptor3;

    public bool Tp1Activated = false;

    public bool Tp2Activated = false;

    public bool Tp3Activated = false;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        ActivateTp(Interruptor1, Teleporter1, Tp1Activated);
        ActivateTp(Interruptor2, Teleporter2, Tp2Activated);
        ActivateTp(Interruptor3, Teleporter3, Tp3Activated);

    }


    void ActivateTp(GameObject Interruptor, GameObject Teleport, bool tpactivate)
    {
        if (Interruptor.GetComponent<InterruptorScript>().IsActivated)
        {
            tpactivate = true;
        }

        if (tpactivate)
        {
            Teleport.GetComponent<TeleporterScript>().isActivated = true;
        }
    }
    
}
