using UnityEngine;

public class Click : MonoBehaviour
{

    public GameObject infoIcon;
    public Vector3 infoPosOffset;

    public void SetActiveInfo(GameObject button)
    {
        infoIcon.SetActive(!infoIcon.active);

        // 인포 아이콘을 클릭 위치 근처로 옮겨온다.
        // 1. 현재 버튼의 위치를 알아온다. 

        Vector3 btnPos = button.transform.position;
        // 2. info의 위치를 버튼 위치 + offset으로  옮긴다. 
        infoIcon.transform.position = btnPos + infoPosOffset;
    }


    //근데 띄우려는 이미지를 내가 원하는 좌표에서 띄우고시픈뎅 주륵


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
