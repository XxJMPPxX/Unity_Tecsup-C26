using UnityEngine;

public class Amogus : MonoBehaviour
{
    private Transform _compTransform;
    private SpriteRenderer _compSpriteRenderer;
    public float velocidadX;
    public float velocidadY;
    public int direccionX = 1;
    public int direccionY = 1;

    void Start()
    {
    }

    void Update()
    {
        _compTransform.position = new Vector3(_compTransform.position.x + velocidadX * direccionX * Time.deltaTime, _compTransform.position.y + velocidadY * direccionY * Time.deltaTime, 0);
        

        
        if (_compTransform.position.x > 4.88f)
        {
            direccionX = -direccionX;
            _compSpriteRenderer.flipX = true;
        }

        if (_compTransform.position.x < -4.88f)
        {
            direccionX = -direccionX;
            _compSpriteRenderer.flipX = false;
        }

        
        if (_compTransform.position.y > 4.2f)
        {
            direccionY = -direccionY;
        }

        
        if (_compTransform.position.y < -4.2f)
        {
            direccionY = -direccionY;
        }
    }

    private void Awake()
    {
        _compTransform = GetComponent<Transform>();
        _compSpriteRenderer = GetComponent<SpriteRenderer>();
    }
}