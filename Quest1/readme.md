# Dot Net Conference Quiz

## Pregunta 1 
```c#
static void Test(out int x, out int y)
{
	x = 42;
	y = 123;
	Console.WriteLine(x == y);
}
```

1. Falso
2. Cierto
3. **Puede ser cierto**
4. No compila

##Solución - Pedro González ([@pedrogovi](https://twitter.com/pedrogovi))
La palabra reservada [out](https://msdn.microsoft.com/es-es/library/t3c3bfhx.aspx) hace que los parámetros del ejemplo sean pasados por referencia. El efecto de pasar parámetros por referencia es que cualquier cambio de estos parámetros dentro del método se refleje fuera del mismo. En este caso, la palabra reservada out tiene el mismo efecto que ref, salvo que esta última requiere que la variable sea inicializada previamente.
En el código que aquí se muestra se están cambiando los valores que tienen la variables que se ha pasado por referencia: x e y.
Si suponemos que la variable que se ha pasado por referencia como parámetro x no es la misma que la variable que se ha pasado como parámetro y, podríamos afirmar que el resultado es que x e y tendrán valores diferentes. Véase el siguiente ejemplo donde se realiza una llamada a dicho método con variables diferentes.
```c#
static void Main()
{
   int a = 1;
   int b = 2;
   Test(out a, out b);
}
```
Sin embargo, si la llamada al método Test se realiza con la misma variable, como se muestra en el ejemplo siguiente, se estaría cambiando el valor de la misma variable y por lo tanto los valores de x e y serían iguales (x = 123, y = 123). No sabemos si x e y van a tener el mismo valor, pero podemos afirmar que podrían tenerlo y la respuesta correcta sería la 3.
```c#
static void Main()
{
   int a = 1;
   Test(out a, out a);
}
```
Para más información podéis visitar la [documentación oficial](https://msdn.microsoft.com/es-es/library/t3c3bfhx.aspx). 

**Solución:** 3. Puede ser cierto
