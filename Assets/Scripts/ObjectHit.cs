using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter(Collision other)
    {
        GetComponent<MeshRenderer>().material.color = Color.red;
        Debug.Log ("Something hit me!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
