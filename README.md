# POO: Juego del Ahorcado 
El juego del ahorcado es un clásico juego de adivinanza de palabras en el que el jugador intenta adivinar letra por letra de una palabra oculta. El juego tiene un número limitado de vidas para adivinar la palabra correspondiente, si el jugador adivina la palabra antes de quedarse sin vidas: gana el juego, de manera contraria: pierde.

---

## Requisitos del juego
1.**Base de Palabras**: El juego debe tener una lista de palabras definidas.

2.**Mostrar palabra oculta**: Al inicio del juego, se deben mostrar algunas letras de la palabra oculta de manera aleatoria para ayudar al jugador.

3.**Intentos Limitados**: El jugador tiene un número limitado de vidas para adivinar la palabra simulando al ahorcado.

4.**Validación de Letras**: El usuario solo puede ingresar letras minúsculas. Si intenta ingresar una letra mayúscula, se muestra un mensaje de error y no se cuenta como vida pérdida.

5.**Mensaje de Victoria/Derrota**: El juego debe indicar si el jugador ganó o perdió la partida, mostrando la palabra correcta.

6.**Reinicio del juego**: El jugador debe tener la opción de jugar otra partida si así lo desea o salir del juego definitivamente.

---

### Diseño del Programa
El programa está diseñado en el lenguaje de Programación C#, utilizando Programación Orientada a Objetos (POO) para organizar el código en clases y métodos.

1.**JuegoAhorcado**: Clase Principal que controla el flujo del juego.

  ├── IniciarJuego()
  
  ├── MostrarEstado()
  
  ├── SolicitarLetra()
  
  ├── MostrarResultadoFinal()

  ├── PreguntarOtraPartida()
  
2.**Palabra**: Clase que maneja la selección y el estado de la palabra a adivinar.

  ├── MostrarAlgunasLetras()

  ├── AdivinarLetra()

  ├── MostrarPalabra()

  ├── PalabraCompleta()

3.**Jugador**: Clase que maneja las vidas y letras incorrectas ingresadas por el jugador.

  ├── PerderVida()

  ├── AgregarLetraIncorrecta(letra)

### Diagrama UML 
