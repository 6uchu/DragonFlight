using UnityEngine;

public class BackGround : MonoBehaviour
{
    public float scrollSpeed = 0.5f;
    private Material myMaterial;


    void Start()
    {
        myMaterial = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newOffset = myMaterial.mainTextureOffset;

        newOffset.Set(newOffset.x, newOffset.y + (scrollSpeed * Time.deltaTime));

        myMaterial.mainTextureOffset = newOffset;
    }
}
