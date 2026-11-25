using UnityEngine;

public class kameraacısı : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject Player;
    private Vector3 offset;
    private Camera MainCamera;

    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        offset = transform.position - Player.transform.position;
        MainCamera = this.gameObject.GetComponent<Camera>();

    }
    void Update()
    {
        MainCamera.transform.position = Player.transform.position + offset;
    }
}
