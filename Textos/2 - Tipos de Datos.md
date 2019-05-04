# Tipos de Datos

Los tipos de datos son aquello con lo que vamos a especificar el dominio de nuestros objetos de trabajo. Entonces un 
tipo de dato es aquello que me ayuda a describir y a segregar una serie de atributos y operaciones que son relevantes 
para el dominio de negocio en el que estemos trabajando. 

En nuestro caso del Algoritmo de multiplicacion por sumas sucesivas, lo resolvimos para los numeros enteros, estos los
segregamos de todo el resto de los numeros que existen para trabajar en su dominio particular.

En los lenguajes fuertemente tipados como son C# o Java vamos a encontrar a los tipos de datos donde se deba describir 
parametros, definir retornos de metodos, definir una variable.

## Boolean

Un bit, true, false. La dualidad. Este tipo de datos es uno de los tipos más básicos que hay en todos los lenguajes 
de programación y es aquello que representa lo verdadero y lo falso, que son con lo que se evaluan las expresiones
logicas.

    bool raining = true;
    bool busOnTime = false;
    
## Enteros

Este tipo de dato numerico, se corresponde con los numeros naturales positivos y negativos y el cero. La unica
salvedad que vale aclarar con respecto a la matematica, es que la cantidad de ese numero esta determinada en su tipo.

En cumputacion se le asigna un determinado tamaño a estos numeros, siendo que los enteros son numeros tan utilizados
en la mayoria de los lenguajes vamos a encontrar definiciones para este tipo de 16, 32, 64 bits. Lo importante son
dos cosas primero que entendamos a que numeros hacemos referencia y segundo que sepamos que hay unos limites, incluso
estos limites son variables segun tomes los naturales con o sin signos. Pero esto se lo veremos en otro momento.

La definicion del tipo la podemos ver en la documentacion de cada lenguaje.

    int positive = 15;
    int negative = -1264;
    int zero = 0;
    var leet = 1337; 

## Strings.

Un string es un tipo de dato que mediante una secuencia de caraceteres representa un texto. 

    string name = "Curso de Programacion";
    var miTexto = "degame en pas";

Cada uno de estos caracteres esta representado por el tipo Char que representa un caracter solo UTF-16. Esta secuencia
de caracteres es inmutable, read-only, una vez que se crea el string este no puede ser modificado, operaciones como
concatenacion de strings no modifican el string original, sino crean uno nuevo. 

