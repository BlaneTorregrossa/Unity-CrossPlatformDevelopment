using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPatternGeneration : MonoBehaviour
{
    public Vector2 Graph;
    public List<Vector2> Bullets = new List<Vector2>();
    public Vector2 PlayerVec;
    public Vector2 goal;
    public GameObject Bullet;
    public Rigidbody rb;

    private Vector3 NewBulletPos = new Vector3(12, 0.0001f, -7.0f);
    private float positionScaler = 2.25f;
    private int xCounter = 0;

    // Creates Graph 
    void GenGraph()
    {
        if (Graph.x >= 5 || Graph.y >= 5)
        {
            xCounter = 0;
        }

        else
        {
            while (Graph.x != xCounter)
            {
                Bullets.Add(Graph);
            }
            while (Graph.x == xCounter)
            {
                Bullets.Add(Graph);
                Graph.y++;
                NewBulletPos += new Vector3(0, 0, 1) * positionScaler;
                Instantiate(Bullet).transform.position = NewBulletPos;
                if (Graph.y >= 5)
                {

                    NewBulletPos.x += 1 * positionScaler;
                    NewBulletPos.z = -7.0f;
                    Graph.y = 0;
                    Graph.x++;
                    xCounter++;
                    GenGraph();
                }
            }
        }
    }




    void Start()
    {

    }

    void Update()
    {
        GenGraph();
    }

}

