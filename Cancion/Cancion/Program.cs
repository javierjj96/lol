﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EloBuddy;
using EloBuddy.SDK.Menu;
using EloBuddy.SDK;
using EloBuddy.SDK.Menu;


namespace Cancion
{
    class Program
    {
        static void Main(string[] args)
        {
            string cancion= "sabes que ya llevo un rato mirandote tengo que bailar contigo hoy (dy) vi que tu mirada ya estaba llamandome muestrame el camino que yo voy (oh) tu, tu eres el iman y yo soy el metal me voy acercando y voy armando el plan solo con pensarlo se acelera el pulso (oh yeah) ya, ya me esta gustando mas de lo normal todos mis sentidos van pidiendo mas esto hay que tomarlo sin ningun apuro despacito quiero respirar tu cuello despacito deja que te diga cosas al oido para que te acuerdes si no estas conmigo despacito quiero desnudarte a besos despacito firmo en las paredes de tu laberinto y hacer de tu cuerpo todo un manuscrito sube sube sube, sube, sube quiero ver bailar tu pelo quiero ser tu ritmo que le ensenes a mi boca tus lugares favoritos (favorito, favorito baby) dejame sobrepasar tus zonas de peligro hasta provocar tus gritos y que olvides tu apellido (daddy yankee) si te pido un beso ven damelo yo se que estas pensandolo llevo tiempo intentandolo mami esto es dando y dandolo sabes que tu corazon conmigo te hace bom bom sabes que esa beba esta buscando de mi bom bom ven prueba de mi boca para ver como te sabe quiero quiero quiero ver cuanto amor a ti te cabe yo no tengo prisa yo me quiero dar el viaje empecemos lento, despues salvaje pasito a pasito, suave suavecito nos vamos pegando, poquito a poquito cuando tu me besas con esa destreza veo que eres malicia con delicadeza pasito a pasito, suave suavecito nos vamos pegando, poquito a poquito y es que esa belleza es un rompecabezas pero pa montarlo aqui tengo la pieza, (oye) despacito quiero respirar tu cuello despacito deja que te diga cosas al oido para que te acuerdes si no estas conmigo despacito quiero desnudarte a besos despacito firmo en las paredes de tu laberinto y hacer de tu cuerpo todo un manuscrito sube, sube, sube, sube, sube quiero ver bailar tu pelo quiero ser tu ritmo que le ensenes a mi boca tus lugares favoritos (favorito, favorito baby) dejame sobrepasar tus zonas de peligro hasta provocar tus gritos y que olvides tu apellido despacito vamos a hacerlo en una playa en puerto rico hasta que las olas griten ay bendito para que mi sello se quede contigo pasito a pasito, suave suavecito nos vamos pegando, poquito a poquito que le ensenes a mi boca tus lugares favoritos (favorito, favorito baby) pasito a pasito, suave suavecito nos vamos pegando, poquito a poquito hasta provocar tus gritos y que olvides tu apellido despacito pasito a pasito, suave suavecito nos vamos pegando, poquito a poquito (ehh ehhh) pasito a pasito, suave suavecito nos vamos pegando, poquito a poquito (ehh ehhh)";
           // System.Threading.Thread.Sleep(10000);
            for (int i = 0; i < cancion.Length; i++)

            {
               // System.Threading.Thread.Sleep(1000);
                string parrafo = cancion.Substring(i,i+20);
                Chat.Say(parrafo);
            }
            
        }
    }
}
