using UnityEngine;
using System.Collections;

public class TrapMovementScript : MonoBehaviour {

    [SerializeField]

    NavMeshAgent Navigation;

    [SerializeField]

    GameObject Trap;

    [SerializeField]

    GameObject Destination;

    [SerializeField]

    GameObject Destination2;

    [SerializeField]

    GameObject Player;

    [SerializeField]

    Vector3 Direction; 

    private string DestinationName;
    private float Distance = 2.5f;
    

    void SelectDestination(Vector3 Destination, string name)
    {
           DestinationName = name;
           Navigation.SetDestination(Destination);
        
    }

    void OnTriggerEnter(Collider Other)
    {

        
        if (Other.gameObject.layer == 10)
        {
            if (DestinationName == Destination.name)
            {
                SelectDestination(Destination2.transform.position, Destination2.name);
            }

            else if(DestinationName == Destination2.name)
            {
                SelectDestination(Destination.transform.position, Destination.name);
            }
        }

        if (Other.gameObject.layer == 11)
        {
            
            if (DestinationName == Destination.name)
            {
                
                SelectDestination(Destination2.transform.position, Destination2.name);
            }

            else if (DestinationName == Destination2.name)
            {
                SelectDestination(Destination.transform.position, Destination.name);
            }
        }

        if (Other.gameObject.layer == 8)
        {
            Other.gameObject.transform.Translate(Direction*Distance, Space.World);
        }
    }

	// Use this for initialization
	void Start () {
        SelectDestination(Destination.transform.position, Destination.name);
        Direction = -Player.transform.forward;
	}
	
	// Update is called once per frame
	void Update () {

       
	
	}
}
