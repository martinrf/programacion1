# 3 - Estructuras de Control

Las estructuras de control, son aquellas sentencias (statements) que le indican a nuestro programa que bloque de codigo
correr o cuantas veces correrlo. Estas estructuras se caracterizan por evaluar condiciones booleanas (condiciones de
true o false) y por tomar una decision con respecto a esta evaluacion.

## If Then Else

La sentencia "if" evalua la siguiente condicion booleana a su derecha y si la evaluacion es verdadera (true) entonces
ejecutara el codigo inmediatamente siguiente. En caso de que la condicion sea evaluada como falsa, se procedera a 
evaluar el siguiente "else if" o de no existir se ejecutara el codigo del bloque "else" en caso de que este exista.

    bool isTrue = true;
    if (isTrue) {
      Console.WriteLine("es verdadero");
    } else {
      Console.WriteLine("es falso");
    }
    
Los bloques de codigo son aquellos encerrados entre { } y no tienen ninguna limitacion, podemos poner cualquier codigo
por ejemplo un if

    int numero = 50;
    if (numero > 0){
      if (numero > 10){
        Console.WriteLine("Es mayor a 10");
      } else {
        Console.WriteLine("Es 1 2 3 4 5 6 7 8 o 9");
      }
    } else {
      Console.WriteLine("es negativo o cero");
    } 

## Switch Case

