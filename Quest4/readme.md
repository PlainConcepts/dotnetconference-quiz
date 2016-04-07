# Dot Net Conference Quiz

## Pregunta 4
```c#
static void Main(string[] args)
{
	double result1 = 3.65d + 0.05d;
	float result2 = 3.65f + 0.05f;
	Console.WriteLine(result1 == 3.7d);
	Console.WriteLine(result2 == 3.7f);
	Console.WriteLine(result1 == result2);
}
```

1. TRUE, TRUE, TRUE
2. TRUE, FALSE, TRUE
3. FALSE, FALSE, FALSE
4. TRUE, TRUE, FALSE
5. FALSE, TRUE, TRUE
6. **FALSE, TRUE, FALSE**

## Soluci�n � Daniel Mart�n ([@danimart1991](https://twitter.com/danimart1991))
Cuando un ordenador necesita contener datos puede resultar sencillo, por ejemplo, un entero, con su representaci�n estandarizada binaria, o puede resultar muy complicado, por ejemplo, un n�mero decimal. Puede parecer sencillo, divides en dos partes el n�mero, que pueden ser representados por dos enteros, y ambos enteros pueden ser transformados a su representaci�n binaria y guardados en el sistema, pero este concepto puede dar problemas, por ejemplo, al intentar guardar un n�mero irracional, o algo m�s sencillo, un tercio, al obtener el valor en coma flotante de un tercio, se obtiene un n�mero peri�dico 0,333..., este valor no puede ser representado de manera sencilla. 
Una soluci�n que se propone en muchos sistemas es la aproximaci�n. Esta aproximaci�n, pasa por dar el n�mero pr�ximo m�s cercano disponible, pero este punto puede dar problemas de c�lculo, inclusive en su transformaci�n a binario. Por ejemplo, y tal y como ocurre en la pregunta 4: 3.65d + 0.05d no siempre puede resultar en 3.7d, y depender� del lenguaje, el compilador y de c�mo se realice la acci�n.
En C# existen varios tipos de n�meros de coma flotante:
-	Float: un n�mero de coma flotante de tipo 32 bit (1 bit para signo, 23 bits para mantisa, y 8 bits de exponente).
-	Double: un n�mero de coma flotante de tipo 64 bit (1 bit para signo, 52 bits de mantisa, y 11 bits de exponente).

[M�s informaci�n](http://www.extremeoptimization.com/resources/Articles/FPDotNetConceptsAndFormats.aspx) sobre los n�mero es coma flotante en C#.

En el c�digo de la pregunta al guardar el resultado double realiza un redondeo, y guarda el resultado m�s pr�ximo disponible que es 3.6999999999999997. Al guardar el resultado float, si realiza un redondeo m�s acorde a lo esperado y si guarda correctamente el valor 3.7, por tanto, al comprarlo, es cierto.


**Soluci�n:** 6. FALSE, TRUE, FALSE
