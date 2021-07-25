using UnityEngine;
using Random = UnityEngine.Random;

public class RevercePanel : MonoBehaviour
{
    private float reverce;
    public Transform pos;

    private void Awake()
    {
        reverce = Random.Range(1.0f,8.0f);
    }

    private void Update()
    {
        pos.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y,
             Mathf.PingPong(Time.time*2, reverce));
    }
}
