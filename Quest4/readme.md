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

## Solución – Daniel Martín ([@danimart1991](https://twitter.com/danimart1991))
Cuando un ordenador necesita contener datos puede resultar sencillo, por ejemplo, un entero, con su representación estandarizada binaria, o puede resultar muy complicado, por ejemplo, un número decimal. Puede parecer sencillo, divides en dos partes el número, que pueden ser representados por dos enteros, y ambos enteros pueden ser transformados a su representación binaria y guardados en el sistema, pero este concepto puede dar problemas, por ejemplo, al intentar guardar un número irracional, o algo más sencillo, un tercio, al obtener el valor en coma flotante de un tercio, se obtiene un número periódico 0,333..., este valor no puede ser representado de manera sencilla. 
Una solución que se propone en muchos sistemas es la aproximación. Esta aproximación, pasa por dar el número próximo más cercano disponible, pero este punto puede dar problemas de cálculo, inclusive en su transformación a binario. Por ejemplo, y tal y como ocurre en la pregunta 4: 3.65d + 0.05d no siempre puede resultar en 3.7d, y dependerá del lenguaje, el compilador y de cómo se realice la acción.
En C# existen varios tipos de números de coma flotante:
-	Float: un número de coma flotante de tipo 32 bit (1 bit para signo, 23 bits para mantisa, y 8 bits de exponente).
-	Double: un número de coma flotante de tipo 64 bit (1 bit para signo, 52 bits de mantisa, y 11 bits de exponente).

[Más información](http://www.extremeoptimization.com/resources/Articles/FPDotNetConceptsAndFormats.aspx) sobre los número es coma flotante en C#.

En el código de la pregunta al guardar el resultado double realiza un redondeo, y guarda el resultado más próximo disponible que es 3.6999999999999997. Al guardar el resultado float, si realiza un redondeo más acorde a lo esperado y si guarda correctamente el valor 3.7, por tanto, al comprarlo, es cierto.


**Solución:** 6. FALSE, TRUE, FALSE
