# Dot Net Conference Quiz

## Pregunta 5
```c#
static void Main(string[] args)
{
	double delta = 0.1;
	int i = 0;
	double value = 0d;
	for (; i < 100; i++)
	{
		value += delta;
	}
	Console.WriteLine(value);
	Console.ReadLine();
}
```

1. Evidentemente no compila
2. 10
3. **Casi 10**
4. No termina
5. 1

## Soluci�n � Daniel Mart�n ([@danimart1991](https://twitter.com/danimart1991))
Cuando un ordenador necesita contener datos puede resultar sencillo, por ejemplo, un entero, con su representaci�n estandarizada binaria, o puede resultar muy complicado, por ejemplo, un n�mero decimal. Puede parecer sencillo, divides en dos partes el n�mero, que pueden ser representados por dos enteros, y ambos enteros pueden ser transformados a su representaci�n binaria y guardados en el sistema, pero este concepto puede dar problemas, por ejemplo, al intentar guardar un n�mero irracional, o algo m�s sencillo, un tercio, al obtener el valor en coma flotante de un tercio, se obtiene un n�mero peri�dico 0,333..., este valor no puede ser representado de manera sencilla. 
Una soluci�n que se propone en muchos sistemas es la aproximaci�n. Esta aproximaci�n, pasa por dar el n�mero pr�ximo m�s cercano disponible, pero este punto puede dar problemas de c�lculo, inclusive en su transformaci�n a binario. Por ejemplo, y tal y como ocurre en la pregunta 4: 3.65d + 0.05d no siempre puede resultar en 3.7d, y depender� del lenguaje, el compilador y de c�mo se realice la acci�n.
En C# existen varios tipos de n�meros de coma flotante:
-	Float: un n�mero de coma flotante de tipo 32 bit (1 bit para signo, 23 bits para mantisa, y 8 bits de exponente).
-	Double: un n�mero de coma flotante de tipo 64 bit (1 bit para signo, 52 bits de mantisa, y 11 bits de exponente).

[M�s informaci�n](http://www.extremeoptimization.com/resources/Articles/FPDotNetConceptsAndFormats.aspx) sobre los n�mero es coma flotante en C#

Por tanto, en este ejemplo, conforme se incrementa value se va redondeando, hasta que al final, casi llega a 10. Debido al redondeo del double se queda en 9,99999999999998.

**Soluci�n:** 3. Casi 10.
