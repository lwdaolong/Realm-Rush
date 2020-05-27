using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode] [SelectionBase]
public class CubeEditor : MonoBehaviour
{
    [SerializeField] [Range(1f, 20f)] float gridSize = 10f;

    TextMesh textMesh;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        textMesh = GetComponentInChildren<TextMesh>();

        Vector3 snapPos = new Vector3();
        snapPos.x = Mathf.RoundToInt(transform.position.x / gridSize) * gridSize;
        snapPos.y = 0;
        snapPos.z = Mathf.RoundToInt(transform.position.z / gridSize) * gridSize;
        transform.position = snapPos;
        string pos = snapPos.x/10 + "," + snapPos.z/10;
        textMesh.text = pos;
    }
}
