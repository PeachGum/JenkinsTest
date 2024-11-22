using UnityEngine;

public class MaterialInstance : MonoBehaviour
{
    Renderer ren;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ren = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        MaterialPropertyBlock mpb = new MaterialPropertyBlock();
        mpb.SetColor("_Color", Color.red);
        ren.SetPropertyBlock(mpb);

    }
}
