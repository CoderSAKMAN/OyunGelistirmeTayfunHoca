using UnityEngine;

public class karakterdonme : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.AngleAxis(-90, Vector3.up);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.AngleAxis(180, Vector3.up);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.AngleAxis(90, Vector3.up);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.AngleAxis(360, Vector3.up);
        }
        if(Input.GetKey(KeyCode.Space))
        {
            transform.rotation = Quaternion.AngleAxis(180, Vector3.up);

        }*/
        if(Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, -90, -0), .03f);
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 90, 0), .03f);
        }
        if(Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, 360, 0), .03f);
        }
        if(Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(0, -180, 0), .03f);
        }
    }
}
