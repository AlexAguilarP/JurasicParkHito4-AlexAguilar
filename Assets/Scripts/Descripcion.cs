using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Descripcion : MonoBehaviour
{
    string texto = "";
    public Text pantalla;
    // Start is called before the first frame update
    void Start()
    {
        pantalla.text = "" + texto;
    }

    // Update is called once per frame
    void Update()
    {
        pantalla.text = "" + texto;
    }
    public void SetDinosaurio(string dino)
    {
        pantalla.text = "";
        if (dino == "rex")
        {
            texto = "El T-Rex un Dinosaurio carnívoro bípedo con un cuerpo, cabeza y cola enormes y extremidades superiores desproporcionadamente pequeñas. Ha sido el animal más temible y feroz que ha habitado la tierra.";
        }
        else if (dino == "tero")
        {
            texto = "Un pterodáctilo es un animal volador ya extinto. Se trata de un reptil prehistórico que, según se desprende de los fósiles hallados en diversas regiones, poseía membranas similares a las que tienen actualmente los murciélagos";
        }
        else if (dino == "steg")
        {
            texto = "El Stegosaurus era un dinosaurio cuadrúpedo y herbívoro, que podía medir nueve metros de largo y cuatro de altura, y pesar hasta tres toneladas.";
        }
        else if (dino == "velo")
        {
            texto = "El Velociraptor fue un pequeño carnívoro muy parecido al Deinonychus en los rasgos pero de menor tamaño que los mismos, este dinosaurio era bípedo con una larga, rígida y delgada cola, en sus extremidades delanteras eran largas y delgadas con uñas afiladas, en sus patas tenían unas particulares garras con forma de hoz";
        }
        else if (dino == "bran")
        {
            texto = "El braquiosaurio era uno de los dinosaurios más altos. Su nombre científico, Brachiosaurus, significa “reptil con brazos”. Los científicos lo bautizaron así por sus largas patas delanteras.";
        }
        else if (dino == "anki")
        {
            texto = "El ankylosaurus fue un animal cuadrúpedo, con un cuerpo amplio y robusto. Tenía un cráneo grande y ancho, con dos cuernos apuntando hacia atrás desde la parte posterior de la cabeza, y dos cuernos por debajo de estos que apuntaban hacia atrás y hacia abajo.";
        }
        pantalla.text = "" + texto;
    }
}
