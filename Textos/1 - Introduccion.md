### Que es programar? 

De googlear un rato llegamos a esto:

* “The purpose of programming is to find a sequence of instructions that will automate performing a specific task or 
    solving a given problem.”

* “Programming is the process of taking an algorithm and encoding it into a notation, a programming language, so that 
   it can be executed by a computer. Although many programming languages and many different types of computers exist, 
   the important first step is the need to have the solution. Without an algorithm there can be no program.”

* “Programming is a creative process done by programmers to instruct a computer on how to do a task”

* “The process of developing and implementing various sets of instructions to enable a computer to do a certain task.”

El propósito de programar es construir un algoritmo capaz de automatizar un proceso o solucionar un problema puntual.

	Para esta construcción, vamos a necesitar aprender las reglas, estructuras y técnicas que nos permiten encontrar 
	esas secuencias finitas de pasos aka algoritmos. Vale hacer hincapie que tenemos que entender desde un principio
	la diferencia que existe entre aprender a hablar y poder expresarse, con esto me refiero a que si bien para
	nosotros va a ser lo mismo describir una secuencia de pasos, que describirla en un lenguaje específico, muchas 
	veces nos referiremos a unas o a las otras de forma indistinta, pero “saber” programar es saber construir 
	esas secuencia aunque no sepas cómo describirlas en un lenguaje en particular.

#### Algoritmos

La RAE define la palabra como:

      Conjunto ordenado y finito de operaciones que permite hallar la solución de un problema.

En Wikipedia la primera linea dice:

    In mathematics and computer science, an algorithm (/ˈælɡərɪðəm/ (About this soundlisten)) is an unambiguous 
    specification of how to solve a class of problems.
     

Disclaimer: esto no son clases de matematicas, asi que algunas cosas las doy por sabidas, otras no las trato con el
rigor teorico que les corresponde, tengase a bien entederlo.

La multiplicacion por ejemplo presenta diferentes algoritmos para distintos tamaños de numeros. 

Tomemos como ejemplo la multiplicacion de numeros enteros, esta requiere del aprendizaje de tablas de multiplicar

    La multiplicación se empieza desde la derecha, teniendo cuidado con la ley de los signos y con colocar las unidades 
    de un orden bajo las unidades del mismo orden (unidades bajo unidades, decenas bajo decenas, centenas bajo centenas,
    etc.). Luego se suman los productos de cada cifra del segundo factor por todas las del primero.
    

            4 1 0 3
    x         2 5 4
    ----------------          
    +     1 6 4 1 2
        2 0 5 1 5
        8 2 0 6 
    ----------------
      1 0 4 2 1 6 2

    4103 × 254 = 1042162

#### Codigo?

El codigo fuente, el documento central de los sistemas de información o programas, es aquel que documenta no solo los 
algoritmos que describen las operaciones que un sistema realiza, sino las interacciones de estos algoritmos entre si.

 
Este codigo fuente es quien va a describir nuestros algoritmos, es el papel donde vamos a escribir aquellos metodos, 
pasos finitos de especificaciones no ambiguas. Para esto como para escribirlo en un papel real a puño y letra, existen
distintos lenguajes. 

Un lenguaje de programacion es una serie de palabras claves, una sintaxis con un cierto lexico que permiten 
describir algoritmos. Hay muchos lenguajes, hay varios paradigmas, y muchas formas de expresar las mismas ideas, 
incluso en un mismo lenguaje estas estructuras te pueden permitir hacer las mismas cosas de distintas formas.

### Ejercicio 1 - Multiplicacion de Enteros.

Queremos escribir un metodo que sea capaz de multiplicar dos numeros enteros menores que 100.

#### Mis primeras palabras

metodo

    estos son nuestras descripciones de pasos, en cada uno de los lenguajes estos se expresaran con alguna palabra clave
    o usando algun signo o estructura.
    
dos

    nos estan indicando la cantidad de entradas que tendra nuestro metodo, no son infinitos, no son tres, son dos sin
    ninguna ambiguedad, dos.

entero

    esto nos esta diciendo que quiero multiplicar un tipo especifico de numeros, que aplica una determinadas regalas
    aritmeticas 
    
menores que X

    una regla de validacion
    
Sabemos que tenemos que hacer, pero no sabemos como hacerlo, asi que empecemos por la parte sencilla, como expresar. (ref ejercicios)

* Describir en lenguaje natural el algoritmo requerido
* Describir en c# el algoritmo requerido.
