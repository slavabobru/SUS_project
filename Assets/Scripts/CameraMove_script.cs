using UnityEngine;

public class CameraMove_script : MonoBehaviour
{
    public Camera camera1;
    public Camera camera2;
    public Camera camera3;
    public int r = 1;
    void Start()
    {
        camera1.enabled = false;
        camera2.enabled = false;
        camera3.enabled = true;
    }
    void FirstPerson()
    {
        camera1.enabled = true;
        camera2.enabled = false;
        camera3.enabled = false;
    }
    void CameraAbove()
    {
        camera1.enabled = false;
        camera2.enabled = true;
        camera3.enabled = false;
    }
    void ThirdPerson()
    {
        camera1.enabled = false;
        camera2.enabled = false;
        camera3.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            r++;
            if (r > 3)
            {
                r = 1;
            }
            if (r == 1)
            {
                Invoke("FirstPerson", 0.5f);
            }
            if (r == 2)
            {
                Invoke("CameraAbove", 0.5f);
            }
            if (r == 3)
            {
                Invoke("ThirdPerson", 0.5f);
            }
        }
    }
}
