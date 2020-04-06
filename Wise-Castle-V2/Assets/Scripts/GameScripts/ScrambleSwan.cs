using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScrambleSwan : MonoBehaviour
{
    [SerializeField]
    Button scramble;

    //create GameObjects
    GameObject winMsg;
    GameObject scrambleButton;
    GameObject item1;
    GameObject item2;
    GameObject item3;
    GameObject item4;
    GameObject item5;
    GameObject item6;
    GameObject item7;

    //shape destinations
    Vector3 shape1Dest = new Vector3(2.47f, -0.17f, 0);
    Vector3 shape2Dest = new Vector3(2.1f, -1.3f, 0);
    Vector3 shape3Dest = new Vector3(2.77f, -1.4f, 0);
    Vector3 shape4Dest = new Vector3(3.37f, -1.03f, 0);
    Vector3 shape5Dest = new Vector3(3.77f, -0.4f, 0);
    Vector3 shape6Dest = new Vector3(4.14f, 0.5f, 0);
    Vector3 shape7Dest = new Vector3(4.71f, 0.27f, 0);

    //points for this game
    int points = 30;

    // Start is called before the first frame update
    void Start()
    {
        //set variables to instances
        item1 = GameObject.FindWithTag("swanShape1");
        item2 = GameObject.FindWithTag("swanShape2");
        item3 = GameObject.FindWithTag("swanShape3");
        item4 = GameObject.FindWithTag("swanShape4");
        item5 = GameObject.FindWithTag("swanShape5");
        item6 = GameObject.FindWithTag("swanShape6");
        item7 = GameObject.FindWithTag("swanShape7");

        //hide win message
        winMsg = GameObject.FindWithTag("winmsg2");
        winMsg.SetActive(false);

        //ensure shapes are in start position
        item1.transform.position = new Vector3(-3f, 0, 0);
        item2.transform.position = new Vector3(-3.35f, -1.14f, 0);
        item3.transform.position = new Vector3(-2.7f, -1.2f, 0);
        item4.transform.position = new Vector3(-2.12f, -0.87f, 0);
        item5.transform.position = new Vector3(-1.72f, -0.24f, 0);
        item6.transform.position = new Vector3(-1.35f, 0.64f, 0);
        item7.transform.position = new Vector3(-0.78f, 0.4f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float dist1 = Vector3.Distance(shape1Dest, item1.transform.position);
        if (dist1 < 0.1)
        {
            item1.transform.position = shape1Dest;
        }

        float dist2 = Vector3.Distance(shape2Dest, item2.transform.position);
        if (dist2 < 0.1)
        {
            item2.transform.position = shape2Dest;
        }

        float dist3 = Vector3.Distance(shape3Dest, item3.transform.position);
        if (dist3 < 0.1)
        {
            item3.transform.position = shape3Dest;
        }

        float dist4 = Vector3.Distance(shape4Dest, item4.transform.position);
        if (dist4 < 0.1)
        {
            item4.transform.position = shape4Dest;
        }

        float dist5 = Vector3.Distance(shape5Dest, item5.transform.position);
        if (dist5 < 0.1)
        {
            item5.transform.position = shape5Dest;
        }

        float dist6 = Vector3.Distance(shape6Dest, item6.transform.position);
        if (dist6 < 0.1)
        {
            item6.transform.position = shape6Dest;
        }

        float dist7 = Vector3.Distance(shape7Dest, item7.transform.position);
        if (dist7 < 0.1)
        {
            item7.transform.position = shape7Dest;
        }

        if (dist1 < 0.01 && dist2 < 0.01 && dist3 < 0.01 && dist4 < 0.01 && dist5 < 0.01 && dist6 < 0.01 && dist7 < 0.01)
        {
            winMsg.SetActive(true);
            Debug.Log("win");
        }

        //award points
        GameObject.FindGameObjectWithTag("Points").GetComponent<PointScript>().AddPoints(points);

    }

    public void OnMouseUp()
    {
        //remove button after clicked
        scrambleButton = GameObject.FindWithTag("scramble2");
        scrambleButton.SetActive(false);

        //shape 1
        item1.transform.position += new Vector3(1, 1, 0);

        //shape 2
        item2.transform.position += new Vector3(2, 1, 0);

        //shape 3
        item3.transform.position += new Vector3(0, 2, 0);

        //shape 4
        item4.transform.position += new Vector3(-2, 1, 0);

        //shape 5
        item5.transform.position += new Vector3(1, -2, 0);

        //shape 6
        item6.transform.position += new Vector3(1, -1, 0);

        //shape 7
        item7.transform.position += new Vector3(-2, 2, 0);

    }
}
