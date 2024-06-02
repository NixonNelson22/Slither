using UnityEngine;
public class goal : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        Debug.Log("GOAL"+transform.position.x + "," + transform.position.y);
        transform.position = new Vector3(Random.Range(-10,10),Random.Range(-5,5),0);
    }
}
