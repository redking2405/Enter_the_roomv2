using UnityEngine;
using System.Collections;

public class TutoScript : MonoBehaviour {


    [SerializeField]

    GameObject Player;

    [SerializeField]

    GameObject Startposition;

    [SerializeField]

    GameObject Triger;

    [SerializeField]

    GameObject Target;

    [SerializeField]

    GameObject Teleport;

    public bool TeleportActivate=false;

    public bool DoorOpen = false;

    public bool TargetIsShot = false;

	// Use this for initialization
	void Start () {
        Player.transform.position = Startposition.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

        if (Target.GetComponent<TargetScript>().IsShot)
        {
            TeleportActivate = true;
        }

        if (TeleportActivate)
        {
            Teleport.GetComponent<TeleporterScript>().isActivated = true;
        }

        if (Triger.GetComponent<InterruptorScript>().IsActivated)
        {
            DoorOpen = true;
            //Lancer l'anim de la porte du Tuto
        }
	}
}
