using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RaycastTest : MonoBehaviour
{
    // Start is called before the first frame 
    // Update is called once per frame
    public LayerMask layersToHit;
    public Button activeButton;
    public Button deactiveButton;
    public GameObject _renderer;
    void Update()
    {

        if
        (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward),
              out RaycastHit hitinfo, 30f, layersToHit, QueryTriggerInteraction.Ignore))
        {
            if (hitinfo.collider.CompareTag("Product"))
            {
                ToggleOutlineRenderer toggleRend = hitinfo.collider.GetComponent<ToggleOutlineRenderer>();
                if (toggleRend != null)
                _renderer = toggleRend._prefabRenderer;
                    toggleRend.Toggle(true);
            }
           
        }
        else
        {
            _renderer.SetActive(false);
        }


    }

    private void Start()
    {
        
        activeButton.onClick.AddListener(()=> StartCoroutine(EnableRenderer(true,0.19f)));
        deactiveButton.onClick.AddListener(()=>StartCoroutine(EnableRenderer(false,0.01f)));
    }


    IEnumerator EnableRenderer(bool toggle, float time)
    {
        yield return new WaitForSeconds(time);
        _renderer.SetActive(toggle) ;
    }
}
