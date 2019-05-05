using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_mao : MonoBehaviour
{
 
    float velocidade_mover, velocida_girar;
 
 
    // Start is called before the first frame update
 
 
    void Start()
    {
    velocidade_mover = 10;
    velocida_girar = 50;    
    }

    // Update is called once per frame
    void Update()
    {
        moverMao();
        girarMao();
    }




void moverMao(){
    
 
        //frente
   if (Input.GetKey("w"))
        {
            // tranform.Translate (X,Y,Z)
            transform.Translate(0,0,(velocidade_mover * Time.deltaTime),Space.Self);
        }

        // atras
        if (Input.GetKey("s"))
        {
             // tranform.Translate (X,Y,Z,Pivot)
            transform.Translate(0, 0, (-velocidade_mover * Time.deltaTime),Space.Self);
        }
        //esquerda
        if (Input.GetKey("a")){

            transform.Translate(0,0,( - velocidade_mover * Time.deltaTime),Space.World);
        }
        //direita
        if (Input.GetKey("d")){
        
            transform.Translate(0,0,(velocidade_mover* Time.deltaTime),Space.World);

        }

}


    void girarMao(){

        if(Input.GetKey("q")){

            transform.Rotate(0,0, (velocida_girar * Time.deltaTime), Space.Self);

        }

         if(Input.GetKey("e")){

            transform.Rotate(0,0, ( - velocida_girar * Time.deltaTime), Space.Self);

        }

         if(Input.GetKey("r")){

            transform.Rotate(0,0,(velocida_girar * Time.deltaTime), Space.World);

        }

         if(Input.GetKey("f")){

            transform.Rotate(0,0,( - velocida_girar * Time.deltaTime), Space.World);

        }



    }














}
