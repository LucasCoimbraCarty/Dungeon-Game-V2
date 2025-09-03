using UnityEngine;

public class Enemy:MonoBehaviour
{
    public string nome;
    public float speed;
    public float vida;
    public float MaxVida;
    public float minVida;
    public Transform target;

    void Start() 
    {
        vida = MaxVida;
        Introduction();
    }

    protected virtual void Introduction() 
    {
        Debug.Log("Feijoada da boa, todo mundo atoa " + nome + "e " + vida + "com " + MaxVida);
    }

    void Move()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position,speed * Time.deltaTime);
    }

    private void Update()
    {
        Move();
    }
}
