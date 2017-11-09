using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SceneManager : MonoBehaviour {
	/*public static int counter;

	private static SceneManager instace = null;

	private bool active;

	public Material[] mats;
	public Material background;
	public Material library;

	public static SceneManager Instance{
		get {
			return instace;
		}
	}

	void Start() {
		mats = GetComponent<Renderer>().materials;
		active = true;
		mats[1] = background;
		for(int i = 0; i < mats.Length; i++) {
			GetComponent<Renderer>().materials = mats;
			active = false;
		}
	}

	void Awake() {
		DontDestroyOnLoad(this.gameObject);
		Count();
		Debug.Log(counter);

		/*if(FindObjectsOfType(GetType()).Length > 1) {
			Destroy(other.gameObject);
		}
	}

	public int Count() {
		counter += 1;
		if(counter >= mats.Length) {
			counter -= 3;
		}
		return counter;
	}*/
}
