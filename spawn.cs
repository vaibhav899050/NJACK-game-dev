using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public GameObject obj;
    private Vector2 bound;
    public float delay = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        bound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(espawn());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawning()
    {
        GameObject object1 = Instantiate(obj) as GameObject;
        object1.transform.position = new Vector2(2 * bound.x, Random.Range(-bound.y, bound.y));
    }

    IEnumerator espawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(delay);
            spawning();
        }
    }
}
