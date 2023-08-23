using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public List<Color> color;
    public MeshRenderer meshRenderer;
    public float delayTime;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        //for (int i = 0; i < color.Count; i++)
        //{
        //    meshRenderer.material.color = color[Random.Range(0, color.Count)];
        //}
    }

    private void OnEnable()
    {
        //for (int i = 0; i < color.Count; i++)
        //{
        //    meshRenderer.material.color = color[Random.Range(0, color.Count)];
        //}
    }

    private void OnDisable()
    {
        //for (int i = 0; i < color.Count; i++)
        //{
        //    meshRenderer.material.color = color[Random.Range(0, color.Count)];
        //}
    }

    private void OnMouseUpAsButton()
    {
        //for (int i = 0; i < color.Count; i++)
        //{
        //    meshRenderer.material.color = color[Random.Range(0, color.Count)];
        //}
    }

    private void OnMouseDown()
    {
        //for (int i = 0; i < color.Count; i++)
        //{
        //    meshRenderer.material.color = color[Random.Range(0, color.Count)];
        //}
    }

    private void OnMouseEnter()
    {
        //for (int i = 0; i < color.Count; i++)
        //{
        //    meshRenderer.material.color = color[Random.Range(0, color.Count)];
        //}
    }

    private void OnMouseExit()
    {
        //for (int i = 0; i < color.Count; i++)
        //{
        //    meshRenderer.material.color = color[Random.Range(0, color.Count)];
        //}
    }

    private void OnMouseOver()
    {
        //for (int i = 0; i < color.Count; i++)
        //{
        //    meshRenderer.material.color = color[Random.Range(0, color.Count)];
        //}
    }

    private void OnMouseDrag()
    {
        //Invoke("ChangeColor", delayTime);
        InvokeRepeating("ChangeColor", 5, 1);
        //CancelInvoke();
    }
    public void ChangeColor()
    {
        for (int i = 0; i < color.Count; i++)
        {
            meshRenderer.material.color = color[Random.Range(0, color.Count)];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        
    }

    void LateUpdate()
    {
        
    }
}
