ld31acs
=============================================================================================================================
Repo para proyecto de la ludum dare 31
tema: juego entero en 1 sola pantalla

=============================================================================================================================
NOMBRE: LD31ACS
DESARROLLADORES: CESAR, SERGIO, ANGELICA
DIC 6 2014
 
IDEA:

un personaje vive tranquilo en un jardín
queda atrapado en su entorno
una guadañadora ó unas aspas de cortacésped empieza a destruir el pasto (modifica el entorno)
el personaje tiene que huir evitando obstáculos del mismo entorno.


Descripcion entorno:
Potrero?
rodeado por calles o asfalto que impiden la salida del personaje?


DESCRIPCIÓN PERSONAJE:
Duende (gnomo) que viene de tierras lejanas y llega a este “potrero”, donde más adelante llegan los antagonistas a molestarlo
Guadaña: Humanos quieren destruir el entorno(ej. se quiere construir, por lo tanto se va a “limpiar” el potrero)
Personaje: Hormiga? 
-Enano ?
-Lagartija
-Ratón?


PLAN DE TRABAJO:

Diseño:
fondos (JUEGO DE NOCHE -- TODO OSCURO EXCEPTO LOS QUE SE ALCANZA A ALUMBRAR CON EL FAROL)
personaje Duende (vista top - se le ve una nariz (se sabe el frente) y detras se le ve una pequeña lampara) http://thumbs.dreamstime.com/z/minero-enano-de-la-historieta-ejemplo-del-vector-38016090.jpg
enemigo guadaña pequeña antigua http://www.empireonline.com/images/features/100greatestgames/stills/27.jpg
obstaculos(piedras - rastrillos)
Objeto para el flash = flor
bordes de pantalla = enredaderas
Programacion
diseñar personaje basico = ok
Un sólo sprite y girar. = ok
Movimiento = ok
diseñar guadaña que siga un camino - o se mueva aleatoriamente.
Movimiento aleatorio
Movimiento en direccion determinada
obstaculos (piedras, llantas, fuego(HACE DAÑO EL FUEGO)?)
->>Obstaculos que hacen daño.
Limites = ok
Colliders = ok
MANAGER DEL JUEGO -- Estatico (guardar partida - controlar configuracion - parametros del jugador)
nombre del player (inmersion)
tiempo de juego
Timer (puede que si o puede que no)(disminuir, aumentar)
Vida
Barra de vida
Porcentaje por daño (Bosses Crash Bandicoot) 
Sonido:
sonido guadaña
sonidos personaje(pasos - cuando le hacen daño - )
sonido ambiente (potrero - bosque ->cerca a carretera)


=============================================================================================================================
Version Alpha v0.1, mecanica basica totalmente terminada
bugs al momento de mover la podadora/guadaña
Falta generacion de mapa aleatorio.
->posicionamiento de obstaculos
->posicionamiento de pickups aleatoriamente

Extras: 
->Generar laberintos
->mas pickups
