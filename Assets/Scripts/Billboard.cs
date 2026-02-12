using UnityEngine;

public class Billboard : MonoBehaviour
{
    void LateUpdate()
    {
        // Текст всегда смотрит туда же, куда и камера
        transform.rotation = Camera.main.transform.rotation;
    }
}
