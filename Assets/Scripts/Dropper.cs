using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 2f;
    MeshRenderer myMeshRenderer;
    Rigidbody myRidgibody;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myMeshRenderer = GetComponent<MeshRenderer>();
        myMeshRenderer.enabled = false;

        myMeshRenderer.enabled = false;
        myRidgibody.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
      if (Time.time > timeToWait)
        {
            myMeshRenderer.enabled = true;
            myRidgibody.useGravity = false;
        }
    }
}
