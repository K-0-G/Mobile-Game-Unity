using UnityEngine;

public class TestScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Hello");
        Debug.Log("There");
        Debug.LogWarning("General");
        Debug.LogError("Kenobi!");
        transform.Rotate(0, 0, 45);


    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Hello World!");
        transform.Translate(0.025f, 0, 0);

    }
}
