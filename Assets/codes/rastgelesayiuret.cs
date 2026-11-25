using UnityEngine;

public class rastgelesayiuret : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            for(int A=0;A<10;A++ )
            {
                Debug.Log(Random.Range(0,10));
            } 
        }
    }
}
