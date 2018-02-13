using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CargarRecursoWeb : MonoBehaviour {

	string url="https://craterstudio.000webhostapp.com/wp-content/uploads/2018/02/cropped-LogoDef.png";
	public Image image;
	public RawImage rawimage;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) {
			StartCoroutine (CargarUIImage());
			StartCoroutine (CargarRawImage());
		}
	}

	IEnumerator CargarUIImage()
	{
		WWW _www = new WWW (url);
		yield return _www;
		Texture2D textura = _www.texture;
		Sprite _sprite = TextureASprite(textura);
		image.sprite = _sprite;
		Debug.Log ("Image"+Time.time);
	}
	Sprite TextureASprite(Texture2D texture)
	{
		Rect rect = new Rect (0, 0, texture.width, texture.height);
		Vector2 pivot = new Vector2 (0.5f, 0.5f);
		Sprite sprite = Sprite.Create (texture, rect, pivot);
		return sprite;
	}


	IEnumerator CargarRawImage()
	{
		WWW _www = new WWW (url);
		yield return _www;
		Texture2D textura = _www.texture;
		rawimage.texture = textura;
		Debug.Log ("Raw"+Time.time);
	}
}
