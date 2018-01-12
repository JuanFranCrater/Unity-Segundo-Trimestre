using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDeHijos : MonoBehaviour {

	public Transform _objPadre;
	int i = 0;
	bool createObjects=true;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Agregar Hijos
		if (Input.GetMouseButtonDown (0)) {
			createObjects = !createObjects;
		}
		if(createObjects)
		{
			GameObject hijo = new GameObject ("Hijo_"+i++.ToString());
			hijo.transform.parent = _objPadre;
			GameObject hijo2 = GameObject.CreatePrimitive (PrimitiveType.Cube);
			Rigidbody rgb = hijo2.AddComponent<Rigidbody> ();
			hijo2.transform.parent=_objPadre;
		}
		//Eliminar Hijos
		if(Input.GetMouseButtonDown(1))
		{
			if (_objPadre.childCount > 0) {
				//Buscar por nombre
				string nombreHijo=_objPadre.transform.GetChild(0).name;
				if(_objPadre.Find(nombreHijo)!=null)
				{
					Destroy(GameObject.Find(nombreHijo).gameObject);
				}
			}
		}
	}
}
