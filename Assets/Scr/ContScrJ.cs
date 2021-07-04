using UnityEngine;

public class ContScrJ : MonoBehaviour {
  
    public Collider2D Col;
    public ConGGScr ContS;
    public Vector3 ClT;
    public Vector3 ClT2;
    public int k = -1;
    public float z = 1;


    void Update()
    {
        
        if ((Input.touches.Length > 0))
        {
            for (int i = 0; i < Input.touchCount; i++)
            {


                if (((Input.touches[i].phase == TouchPhase.Began)))
                {
                    ClT = new Vector3(Camera.main.ScreenToWorldPoint(Input.touches[i].position).x, Camera.main.ScreenToWorldPoint(Input.touches[i].position).y, z);
                    if (Col.bounds.Contains(ClT))//Col.bounds.Contains(ClT))
                    {
                        ContS.Jump();
                        k = i;
                    }

                    ClT2 = new Vector3(Camera.main.ScreenToWorldPoint(Input.touches[i].position).x, Camera.main.ScreenToWorldPoint(Input.touches[i].position).y, z);
                }

            }
        }
        
}
}
