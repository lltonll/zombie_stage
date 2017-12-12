using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFire : MonoBehaviour {

	[SerializeField] private AudioSource source;
	[SerializeField] private AudioClip fireSound;

	public float damage = 10.0f;
	public float range = 100.0f;
	public float fireRate = 15.0f;

	public Camera fpsCam;
	public ParticleSystem muzzleFlash;
	public GameObject impactEffect;

	private float nextTimeToFire = 0f;

	// Use this for initialization
	void Start () {
//		fpsCam = GetComponent<Camera> ();

		Cursor.lockState = CursorLockMode.Locked;
		Cursor.visible = false;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButton ("Fire1") && Time.time >= nextTimeToFire) {
			nextTimeToFire = Time.time + 1.0f / fireRate;
			Shoot ();
		}
	}

	// void OnGUI() {
//		int size = 12;
//		float posX = fpsCam.pixelWidth/2 - size/4;
//		float posY = fpsCam.pixelHeight/2 - size/2;
//		GUI.Label(new Rect(posX, posY, size, size), "*");
	// }

	void Shoot () {
		muzzleFlash.Play ();
		source.PlayOneShot(fireSound);

		Vector3 point = new Vector3 (fpsCam.pixelWidth / 2, fpsCam.pixelHeight / 2, 0);
		Ray ray = fpsCam.ScreenPointToRay (point);
		RaycastHit hit;
		if (Physics.Raycast (ray, out hit, range)) {
//			Debug.Log (hit.transform.name);
			GameObject impactGO = Instantiate (impactEffect, hit.point, Quaternion.LookRotation (hit.normal));
			GameObject hitObject = hit.transform.gameObject;
			ReactiveTarget target = hitObject.GetComponent<ReactiveTarget>();
			if (target != null) {
//				Debug.Log ("Target hit!");
				target.ReactToHit(damage);
			}
			Destroy (impactGO, 2.0f);
//			StartCoroutine (SphereIndicator (hit.point));
		}
	}

	private IEnumerator SphereIndicator(Vector3 pos) {
		GameObject sphere = GameObject.CreatePrimitive (PrimitiveType.Sphere);
		sphere.transform.position = pos;

		yield return new WaitForSeconds (0.1f);
		Destroy (sphere);
	}
}
