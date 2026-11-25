using UnityEngine;

public class rastgelenesneuret : MonoBehaviour
{
    public GameObject chest;


    void Start()
    {

        for (int i=0;i<10;i++)
        {
            int x = Random.Range(0, 100);
            int y = 1;
            int z = Random.Range(0, 100);
            Instantiate(chest,new Vector3(x,y,z),Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
