using UnityEngine;

public class BackGroundMove : MonoBehaviour
{
    public float scrollSpeed = 0.5f;
    private Material myMaterial;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myMaterial = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 offset = myMaterial.mainTextureOffset;
        offset.Set(0, offset.y + (Time.deltaTime * scrollSpeed));
        myMaterial.mainTextureOffset = offset;
    }
}
