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

##Solución – Francisco Olmedo ([@fmolmedo](https://twitter.com/fmolmedo))
Repasamos los posibles puntos de interés: 
En primer lugar, la asignación de la variable value es correcta, ya que se hace conversión implícita de entero a float.
Posteriormente, la sentencia --value equivaldría a value = value - 1, por lo que también es correcta.
Por lo tanto, nos queda incidir en la pérdida de precisión por usar una variable de tipo float. Para su representación se utilizan 32 bits, de los cuales 1 es para el signo, 23 para la representación de la mantisa y 8 para el exponente. Por lo tanto, si tenemos 23 bits (24 si consideramos que el bit más significativo se asume a 1) para la mantisa, podemos representar: log10(2^24) ~= 7 dígitos significativos. Por lo tanto, el rango de enteros que se pueden representar con un float sin pérdida de precisión es el siguiente: [-16777216 - 16777216]. El número que le asignamos no entra en ese rango, con lo que, la operación de restar uno no se llevaría a cabo como se espera; y, consecuentemente, no se llegaría nunca a salir del bucle.

**Solución:** 3. Nunca se imprime el valor de Value
