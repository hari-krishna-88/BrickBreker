using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelGenerator : MonoBehaviour
{

    public Vector2Int size;
    public Vector2 offset;
    public GameObject brickPrefabs;
    public Gradient gradient;

    // for score 





    private void Awake()
    {
        for (int i = 0; i < size.x; i++)
        {
            for (int j = 0; j < size.y; j++)
            {
                GameObject newBrick = Instantiate(brickPrefabs, transform);
                newBrick.transform.position = transform.position + new Vector3((float)((size.x - 1) * .5f - i) * offset.x, j * offset.y, 0);

                // this is for to appaly the gradient color to the brick. 

                newBrick.GetComponent<SpriteRenderer>().color = gradient.Evaluate((float)j / (size.y - 1));
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }


}
