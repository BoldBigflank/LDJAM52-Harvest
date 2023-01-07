using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOutSphere : MonoBehaviour
{
    public Material onMaterial;
    public Material offMaterial;

    private MeshRenderer meshRenderer;

    [SerializeField]
    public bool on {
        get { return m_on; }
        set { m_on = value; }
    }
    private bool m_on;

    public GameObject[] neighbors;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        m_on = false;
        UpdateColor();
    }

    public void Toggle() {
        m_on = !m_on;
        UpdateColor();
    }

    void UpdateColor() {
        meshRenderer.material.SetColor("_Color", on ? Color.yellow : Color.grey);
    }

    private void OnMouseUpAsButton() {
        Toggle();
        foreach (GameObject neighbor in neighbors) {
            neighbor.SendMessage("Toggle");
        }
        gameObject.transform.parent.gameObject.SendMessage("CheckSolution");
    }
}
