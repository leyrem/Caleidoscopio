using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{

    private LineRenderer _lineRenderer;
    public List<Vector3> pos_laser = new List<Vector3>();

    // Start is called before the first frame update
    void Start()
    {
        _lineRenderer = GetComponent<LineRenderer>();
        //_lineRenderer.SetPosition(0, transform.position);

        //pos_laser.Add(new Vector3((float)-2, (float)-2.5)); // init pos
        //pos_laser.Add(new Vector3((float)5.8, (float)-2.5)); // end pos

        _lineRenderer.SetPositions(pos_laser.ToArray());
        _lineRenderer.useWorldSpace = true;

    }

    // Update is called once per frame
    void Update()
    {
         _lineRenderer.SetPositions(pos_laser.ToArray());
        RaycastHit2D hit = Physics2D.Raycast(pos_laser[0], new Vector2(0,1));
        if (hit.collider & !hit.collider.name.Equals("Player") & !hit.collider.name.Equals("SquareLiana"))
        {
        
            List<Vector3> new_pos = new List<Vector3>();  
            new_pos.Add(pos_laser[0]);
            new_pos.Add(new Vector3(hit.point.x, hit.point.y));
            
            _lineRenderer.SetPositions(new_pos.ToArray());
            
           
        } else if(hit.collider & hit.collider.name.Equals("Player"))
        {
           
        }
        else if(hit.collider & hit.collider.name.Equals("SquareLiana"))
        {
           
        }
        else
        {

            _lineRenderer.SetPositions(pos_laser.ToArray());

           
        }

        
    }
}
