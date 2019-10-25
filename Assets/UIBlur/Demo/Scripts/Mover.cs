using UnityEngine;

namespace UIBlur.Demo {

class Mover : MonoBehaviour {
	public Vector3 startPosition = Vector3.zero;
	public Vector3 endPosition = Vector3.zero;
	public float speed = 1f;
	public Vector3 turbulence = Vector3.zero;
	public float turbulenceSpeed = 1f;
	
	void FixedUpdate() {
		var pos = transform.localPosition;
		
		float t = Mathf.Sin(Time.time * speed) * 0.5f + 0.5f;
		pos = Vector3.Lerp(startPosition, endPosition, t);

		t = Mathf.Sin(Time.time * turbulenceSpeed) * 0.5f + 0.5f;
		pos += Vector3.Lerp(-turbulence, turbulence, t);

		transform.localPosition = pos;
	}
}

}