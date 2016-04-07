# Dot Net Conference Quiz

## Pregunta 2
```c#
static void Main(string[] args)
{
	float value = 100000000;
	while(value > 0)
	{
		--value;
	}
	Console.WriteLine("Value es {0}", value);
}
```

1. Value es 0
2. Value es 0.00000001
3. **Nunca se imprime el valor de Value**
4. No compila

##Soluci�n � Francisco Olmedo ([@fmolmedo](https://twitter.com/fmolmedo))
Repasamos los posibles puntos de inter�s: 
En primer lugar, la asignaci�n de la variable value es correcta, ya que se hace conversi�n impl�cita de entero a float.
Posteriormente, la sentencia --value equivaldr�a a value = value - 1, por lo que tambi�n es correcta.
Por lo tanto, nos queda incidir en la p�rdida de precisi�n por usar una variable de tipo float. Para su representaci�n se utilizan 32 bits, de los cuales 1 es para el signo, 23 para la representaci�n de la mantisa y 8 para el exponente. Por lo tanto, si tenemos 23 bits (24 si consideramos que el bit m�s significativo se asume a 1) para la mantisa, podemos representar: log10(2^24) ~= 7 d�gitos significativos. Por lo tanto, el rango de enteros que se pueden representar con un float sin p�rdida de precisi�n es el siguiente: [-16777216 - 16777216]. El n�mero que le asignamos no entra en ese rango, con lo que, la operaci�n de restar uno no se llevar�a a cabo como se espera; y, consecuentemente, no se llegar�a nunca a salir del bucle.

**Soluci�n:** 3. Nunca se imprime el valor de Value
