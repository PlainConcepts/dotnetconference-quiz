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

##Soluci�n - Pedro Gonz�lez ([@pedrogovi](https://twitter.com/pedrogovi))
La palabra reservada [out](https://msdn.microsoft.com/es-es/library/t3c3bfhx.aspx) hace que los par�metros del ejemplo sean pasados por referencia. El efecto de pasar par�metros por referencia es que cualquier cambio de estos par�metros dentro del m�todo se refleje fuera del mismo. En este caso, la palabra reservada out tiene el mismo efecto que ref, salvo que esta �ltima requiere que la variable sea inicializada previamente.
En el c�digo que aqu� se muestra se est�n cambiando los valores que tienen la variables que se ha pasado por referencia: x e y.
Si suponemos que la variable que se ha pasado por referencia como par�metro x no es la misma que la variable que se ha pasado como par�metro y, podr�amos afirmar que el resultado es que x e y tendr�n valores diferentes. V�ase el siguiente ejemplo donde se realiza una llamada a dicho m�todo con variables diferentes.
```c#
static void Main()
{
   int a = 1;
   int b = 2;
   Test(out a, out b);
}
```
Sin embargo, si la llamada al m�todo Test se realiza con la misma variable, como se muestra en el ejemplo siguiente, se estar�a cambiando el valor de la misma variable y por lo tanto los valores de x e y ser�an iguales (x = 123, y = 123). No sabemos si x e y van a tener el mismo valor, pero podemos afirmar que podr�an tenerlo y la respuesta correcta ser�a la 3.
```c#
static void Main()
{
   int a = 1;
   Test(out a, out a);
}
```
Para m�s informaci�n pod�is visitar la [documentaci�n oficial](https://msdn.microsoft.com/es-es/library/t3c3bfhx.aspx). 

**Soluci�n:** 3. Puede ser cierto
