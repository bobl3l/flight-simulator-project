using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class RoadSpawner : MonoBehaviour
{
	public List<GameObject> roads;
	private float offset = 100f;
    // Start is called before the first frame update
    void Start()
    {
        if(roads != null && roads.Count > 0)
        {
        	roads = roads.OrderBy(r => r.transform.position.z).ToList();
        }
    }

    public void MoveRoad()
    {
    	GameObject movedRoad = roads[0];
    	roads.Remove(movedRoad);
    	float newZ = roads[roads.Count - 1].transform.position.z + offset;
    	movedRoad.transform.position = new Vector3((float)43.688,(float)-11.40708, newZ);
    	roads.Add(movedRoad);
    }
}
