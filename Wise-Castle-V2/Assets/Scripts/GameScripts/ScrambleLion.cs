using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScrambleLion : MonoBehaviour
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
    GameObject item8;
    GameObject item9;
    GameObject item10;
    GameObject item11;
    GameObject item12;
    GameObject item13;
    GameObject item14;

    //shape destinations
    Vector3 shape1Dest = new Vector3(0.5f, -1.6f, 0);
    Vector3 shape2Dest = new Vector3(1.33f, -1.15f, 0);
    Vector3 shape3Dest = new Vector3(3.05f, -0.1f, 0);
    Vector3 shape4Dest = new Vector3(2.12f, -1.6f, 0);
    Vector3 shape5Dest = new Vector3(2.58f, -1.85f, 0);
    Vector3 shape6Dest = new Vector3(3.6f, -1.79f, 0);
    Vector3 shape7Dest = new Vector3(4f, -0.4f, 0);
    Vector3 shape8Dest = new Vector3(5.55f, -0.92f, 0);
    Vector3 shape9Dest = new Vector3(5.97f, -1.9f, 0);
    Vector3 shape10Dest = new Vector3(7.05f, -1.98f, 0);
    Vector3 shape11Dest = new Vector3(5.7f, 0.42f, 0);
    Vector3 shape12Dest = new Vector3(6.8f, 0.88f, 0);
    Vector3 shape13Dest = new Vector3(6.8f, -0.13f, 0);
    Vector3 shape14Dest = new Vector3(7.37f, 0.18f, 0);

    //points for this game
    int points = 50;

    // Start is called before the first frame update
    void Start()
    {
        //set variables to instances
        item1 = GameObject.FindWithTag("lionShape1");
        item2 = GameObject.FindWithTag("lionShape2");
        item3 = GameObject.FindWithTag("lionShape3");
        item4 = GameObject.FindWithTag("lionShape4");
        item5 = GameObject.FindWithTag("lionShape5");
        item6 = GameObject.FindWithTag("lionShape6");
        item7 = GameObject.FindWithTag("lionShape7");
        item8 = GameObject.FindWithTag("lionShape8");
        item9 = GameObject.FindWithTag("lionShape9");
        item10 = GameObject.FindWithTag("lionShape10");
        item11 = GameObject.FindWithTag("lionShape11");
        item12 = GameObject.FindWithTag("lionShape12");
        item13 = GameObject.FindWithTag("lionShape13");
        item14 = GameObject.FindWithTag("lionShape14");

        //hide win message
        winMsg = GameObject.FindWithTag("winmsg3");
        winMsg.SetActive(false);

        //ensure shapes are in start position
        item1.transform.position = new Vector3(-8f, -1.6f, 0);
        item2.transform.position = new Vector3(-7.14f, -1.15f, 0);
        item3.transform.position = new Vector3(-5.54f, -0.24f, 0);
        item4.transform.position = new Vector3(-6.43f, -1.69f, 0);
        item5.transform.position = new Vector3(-5.95f, -1.94f, 0);
        item6.transform.position = new Vector3(-4.95f, -1.9f, 0);
        item7.transform.position = new Vector3(-4.59f, -0.52f, 0);
        item8.transform.position = new Vector3(-3.02f, -1, 0);
        item9.transform.position = new Vector3(-2.62f, -2f, 0);
        item10.transform.position = new Vector3(-1.52f, -2.1f, 0);
        item11.transform.position = new Vector3(-2.87f, 0.35f, 0);
        item12.transform.position = new Vector3(-1.77f, 0.9f, 0);
        item13.transform.position = new Vector3(-1.77f, -0.06f, 0);
        item14.transform.position = new Vector3(-1.19f, 0.23f, 0);
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

        float dist8 = Vector3.Distance(shape8Dest, item8.transform.position);
        if (dist8 < 0.1)
        {
            item8.transform.position = shape8Dest;
        }

        float dist9 = Vector3.Distance(shape9Dest, item9.transform.position);
        if (dist9 < 0.1)
        {
            item9.transform.position = shape9Dest;
        }

        float dist10 = Vector3.Distance(shape10Dest, item10.transform.position);
        if (dist10 < 0.1)
        {
            item10.transform.position = shape10Dest;
        }

        float dist11 = Vector3.Distance(shape11Dest, item11.transform.position);
        if (dist11 < 0.1)
        {
            item11.transform.position = shape11Dest;
        }

        float dist12 = Vector3.Distance(shape12Dest, item12.transform.position);
        if (dist12 < 0.1)
        {
            item12.transform.position = shape12Dest;
        }

        float dist13 = Vector3.Distance(shape13Dest, item13.transform.position);
        if (dist13 < 0.1)
        {
            item13.transform.position = shape13Dest;
        }

        float dist14 = Vector3.Distance(shape14Dest, item14.transform.position);
        if (dist14 < 0.1)
        {
            item14.transform.position = shape14Dest;
        }

        if (dist1 < 0.01 && dist2 < 0.01 && dist3 < 0.01 && dist4 < 0.01 && dist5 < 0.01 && dist6 < 0.01 && dist7 < 0.01 
            && dist8 < 0.01 && dist9 < 0.01 && dist10 < 0.01 && dist11 < 0.01 && dist12 < 0.01 && dist13 < 0.01 && dist14 < 0.01)
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
        scrambleButton = GameObject.FindWithTag("scramble3");
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

        //shape 8
        item8.transform.position += new Vector3(1, 1, 0);

        //shape 9
        item9.transform.position += new Vector3(2, 1, 0);

        //shape 10
        item10.transform.position += new Vector3(0, 2, 0);

        //shape 11
        item11.transform.position += new Vector3(-2, 1, 0);

        //shape 12
        item12.transform.position += new Vector3(1, -2, 0);

        //shape 13
        item13.transform.position += new Vector3(1, -1, 0);

        //shape 14
        item14.transform.position += new Vector3(-2, 2, 0);

    }
}
