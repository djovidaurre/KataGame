# KataGameLOfLife

Creacion de juego de la vida aplicando TDD

El juego de la vida es un interesante juego matemático ideado por Conway, este juego tiene espectaculares aplicaciones, pero lo que realmente lo hace impresionante es que solo requiere un par de sencillas reglas para funcionar.

Se ha realizado la implementacion del Juego de la Vida aplicando de manera estricta TDD.

# Estrategia
Una vez analizado el juego, se ha implementado el algoritmo de los escenario del juego con la ayuda de los siguientes Test Unitario:

- Mantener vivo la celula, cuando existe dos celulas vivas vecinas.
- Mantener vivo la celula, cuando existe tres celulas vivas vecinas.
- Muerte de celula vida por sobrepoblacion,  por tener tres celulas vivas vecinas.
- Muerte de celula vida por solitario, por tener una celula vida vecinas.
- Revive celular muerta, por tener tres celular vivas vecinas.

El juego esta implementacion en el lenguaje C# usando el IDE Visual Studio 2017.

# Ejecutar Test Unitarios

Para ejecutar el proyecto en su ambiente debe realizar los siguientes pasos:
- Clonar o descargar el proyecto.
- Abrir el proyecto mediante el IDE Visual Studio.
- Para ejecutar las pruebas, en la barra superior del IDE, hacer click en la opcion "Pruebas" y seleccionar "Ejecutar" y clickear en "Todas las pruebas".
    -> Despues de ejecutar esta opcion, aparecera el siguiente "Explorador de Pruebas".
    




