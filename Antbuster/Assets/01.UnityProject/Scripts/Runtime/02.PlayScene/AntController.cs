using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AntController : MonoBehaviour
{
    public GameObject antPrefab = default;
    public GameObject[] ants = default;

    private int count = default;
    private int currentIndex = default;
    private Vector2 poolPosition = new Vector2(-400, 300);


    private float speed = 1f;

    // Start is called before the first frame update
    void Start()
    {
        //count = 6;
        //ants = new GameObject[count];

        //for (int i = 0; i < count; i++)
        //{
        //    gameObject.SetActive(false);

        //    ants[i] = Instantiate(antPrefab, poolPosition, Quaternion.identity);

        //    gameObject.SetActive(true);
        //    currentIndex++;

        //    if (currentIndex >= count)
        //    {
        //        currentIndex = 0;
        //    }
        //    StartCoroutine(Wait());
        //}
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
    }

    public IEnumerator Wait()
    {
        yield return new WaitForSeconds(1f);
    }
}
