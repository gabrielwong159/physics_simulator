using UnityEngine;
using System.Collections;

public class LinearTransformation : MonoBehaviour {

    public const bool COUNTERCLOCKWISE = true;
    public const bool CLOCKWISE = false;

    public static Vector3 xyRotation(Vector3 vector, float theta, bool direction) {
        float cos = Mathf.Cos(direction ? theta : -theta);
        float sin = Mathf.Sin(direction ? theta : -theta);

        return new Vector3(vector.x * cos - vector.y * sin, vector.x * sin + vector.y * cos, vector.z);
    }

    public static Vector3 xzRotation(Vector3 vector, float theta, bool direction) {
        float cos = Mathf.Cos(direction ? theta : -theta);
        float sin = Mathf.Sin(direction ? theta : -theta);

        return new Vector3(vector.x * cos - vector.z * sin, vector.y, vector.x * sin + vector.z * cos);
    }
}

