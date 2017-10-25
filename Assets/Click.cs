using UnityEngine;

public class Click : MonoBehaviour {

    public GameObject Building;

    public void BuildingSetActive()
    {
        Building.SetActive(!Building.active);
    }
    //근데 띄우려는 이미지를 내가 원하는 좌표에서 띄우고시픈뎅 주륵


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
