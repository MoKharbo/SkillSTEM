using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

public class Parabola : MonoBehaviour
{
    
    [SerializeField] private Vector2 minScreen, maxScreen;
    [SerializeField] private int numberofPoints = 10;
    [SerializeField] private float a = -1f, b = 1f, c = 1f;
    [SerializeField] private Point pointprefab;

    void Start()
    {
        minScreen = Camera.main.ScreenToWorldPoint(Vector2.zero);
        maxScreen = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            QuadraticFunction quadratic = new QuadraticFunction(a, b, c);
            float dx = (maxScreen.x - minScreen.x) / (numberofPoints-1);
            for (int i = 0; i < numberofPoints; i++)
            {
                float x = minScreen.x + i * dx;
                float y = quadratic.CalculateY(x);

                // Point pointcopy = Instantiate(pointprefab);
                // pointcopy.x = x;
                // pointcopy.y = y;
            }
        }
    }
}
