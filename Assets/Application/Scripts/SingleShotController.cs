using UnityEngine;

public class SingleShotController : MonoBehaviour
{
    [SerializeField]
    private Color activatedColor = Color.green;

    [SerializeField]
    private float resetTime = 0.75f;

    private Color originalColor;

    private Material material;

    private float timeActivated = float.MinValue;

    public void ShowActivated()
    {
        timeActivated = Time.time;
    }

    private void Start()
    {
        material = GetComponent<Renderer>().material;
        originalColor = material.color;
    }

    void Update()
    {
        var desiredColor = Time.time - timeActivated > resetTime ? 
            originalColor : activatedColor;
        if (material.color != desiredColor)
        {
            material.color = desiredColor;
        }
    }
}
