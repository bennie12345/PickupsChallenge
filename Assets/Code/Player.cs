using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    public int m_score = 0;
	public float playerMoveSpeed = 1f;
    public bool goSlow = false;
    public bool goRotate = false;

    // Update is called once per frame
    void Update()
    {
        //beweeg de speler naar rechts
        this.transform.position += Vector3.right * playerMoveSpeed * Time.deltaTime;
        if (goSlow)
        {
            playerMoveSpeed = 0.5f;    
        }
        if (goRotate)
        {
            RotationFunction();
        }
    }

    public void RotationFunction()
    {
        this.transform.Rotate(0, 0, 1);
    }

    public void CoinsCollected()
    {
        m_score++;
    }
}
