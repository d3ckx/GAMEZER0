using UnityEngine;

public class PLAYER : MonoBehaviour
{
   
    public float velocidade = 0.7f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       
            if (Input.GetKey(KeyCode.A))
                gameObject.transform.position += new Vector3(-velocidade * Time.deltaTime, 0, 0);

            if (Input.GetKey(KeyCode.D))
                gameObject.transform.position += new Vector3(velocidade * Time.deltaTime, 0, 0);

            if (Input.GetKey(KeyCode.S))
                gameObject.transform.position += new Vector3(0, -velocidade * Time.deltaTime, 0); // Corrigido a linha aqui

            if (Input.GetKey(KeyCode.W))
                gameObject.transform.position += new Vector3(0, velocidade * Time.deltaTime, 0); // Corrigido a linha aqui
        }
    }
        
    

