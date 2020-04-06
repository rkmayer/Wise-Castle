using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScrambleRabbit : MonoBehaviour
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
    Vector3 shape1Dest = new Vector3(2.75f, 1.48f, 0);
    Vector3 shape2Dest = new Vector3(2.35f, 0.83f, 0);
    Vector3 shape3Dest = new Vector3(3.1f, 0.15f, 0);
    Vector3 shape4Dest = new Vector3(2.42f, 0.1f, 0);
    Vector3 shape5Dest = new Vector3(3.4f, -1.01f, 0);
    Vector3 shape6Dest = new Vector3(2.48f, -0.93f, 0);
    Vector3 shape7Dest = new Vector3(3.7f, -1.5f, 0);

    //points for this game
    int points = 15;

    // Start is called before the first frame update
    void Start()
    {

        //set variables to instances
        item1 = GameObject.FindWithTag("rabbitShape1");
        item2 = GameObject.FindWithTag("rabbitShape2");
        item3 = GameObject.FindWithTag("rabbitShape3");
        item4 = GameObject.FindWithTag("rabbitShape4");
        item5 = GameObject.FindWithTag("rabbitShape5");
        item6 = GameObject.FindWithTag("rabbitShape6");
        item7 = GameObject.FindWithTag("rabbitShape7");

        //hide win message
        winMsg = GameObject.FindWithTag("winmsg");
        winMsg.SetActive(false);

        //ensure shapes are in start position
        item1.transform.position = new Vector3(-3f, 1.5f, 0);
        item2.transform.position = new Vector3(-3.5f, 0.85f, 0);
        item3.transform.position = new Vector3(-2.75f, 0.15f, 0);
        item4.transform.position = new Vector3(-3.42f, 0.1f, 0);
        item5.transform.position = new Vector3(-2.4f, -1.01f, 0);
        item6.transform.position = new Vector3(-3.34f, -0.95f, 0);
        item7.transform.position = new Vector3(-2.13f, -1.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //check shape 1
        //if (item1)
        //{
            float dist1 = Vector3.Distance(shape1Dest, item1.transform.position);
            if(dist1 < 0.1)
            {
                item1.transform.position = shape1Dest;
            }
           
            Debug.Log("Distance to other: " + dist1);
        //}

        //check shape 2
        //if (item2)
       // {
            float dist2 = Vector3.Distance(shape2Dest, item2.transform.position);
            if (dist2 < 0.1)
            {
                item2.transform.position = shape2Dest;
            }

            Debug.Log("Distance to other: " + dist2);
        //}

        //check shape 3
       // if (item3)
       // {
            float dist3 = Vector3.Distance(shape3Dest, item3.transform.position);
            if (dist3 < 0.1)
            {
                item3.transform.position = shape3Dest;
            }
         
            Debug.Log("Distance to other: " + dist3);
       // }

        //check shape 4
        //if (item4)
       // {
            float dist4 = Vector3.Distance(shape4Dest, item4.transform.position);
            if (dist4 < 0.1)
            {
                item4.transform.position = shape4Dest;
            }

            Debug.Log("Distance to other: " + dist4);
       // }

        //check shape 5
       // if (item5)
       //
            float dist5 = Vector3.Distance(shape5Dest, item5.transform.position);
            if (dist5 < 0.1)
            {
                item5.transform.position = shape5Dest;
            }

            Debug.Log("Distance to other: " + dist5);
       // }

        //check shape 6
       // if (item6)
       // {
            float dist6 = Vector3.Distance(shape6Dest, item6.transform.position);
            if (dist6 < 0.1)
            {
                item6.transform.position = shape6Dest;
            }

            Debug.Log("Distance to other: " + dist6);

            float dist7 = Vector3.Distance(shape7Dest, item7.transform.position);
            if (dist7 < 0.1)
            {
                item7.transform.position = shape7Dest;
            }

            Debug.Log("Distance to other: " + dist7);


        if( dist1 < 0.01 && dist2 < 0.01 && dist3 < 0.01 && dist4 < 0.01 && dist5 < 0.01 && dist6 < 0.01 && dist7 < 0.01)
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
        scrambleButton = GameObject.FindWithTag("scramble");
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
