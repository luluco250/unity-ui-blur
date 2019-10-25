using UnityEngine;

namespace UIBlur.Demo {

class Spinner : MonoBehaviour {
	public Vector3 rotationSpeed = Vector3.zero;
	Vector3 rotation;

	void Start() {
		rotation = transform.localEulerAngles;
	}

	void FixedUpdate() {
		rotation += rotationSpeed;
		transform.localRotation = Quaternion.Euler(rotation);
	}
}

}