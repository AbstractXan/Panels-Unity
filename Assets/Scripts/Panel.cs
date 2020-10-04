using UnityEngine;

public class Panel : MonoBehaviour
{
    void OnMouseEnter()
    {
	transform.localScale += new Vector3(2.0f,2.0f,0.0f);
	transform.Translate(Vector3.back);
        Debug.Log("Mouse Enter");
    }	
    void OnMouseExit()
    {
	transform.localScale += new Vector3(-2.0f,-2.0f,0.0f);
	transform.Translate(Vector3.forward);
        Debug.Log("Mouse Exit");
    }	
}
