using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] int createCount = 10000;
    Material mat;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int row = (int)(createCount * 0.1f); // 8
        int col = createCount / row; // 10
        for(int a=0; a< createCount; a++)
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            int x = a % row;
            int z = a / col;
            //cube.transform.position = new Vector3(x * 1 * 2, 0, z * 1 * 2);
            cube.transform.position = Vector3.zero;
            Renderer ren = cube.GetComponent<Renderer>();
            if (mat == null)
            {
                mat = ren.material;
                mat.enableInstancing = true;
            }
            else
            {
                ren.material = mat;
            }

        }
    }
}
