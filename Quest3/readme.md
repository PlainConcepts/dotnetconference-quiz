# Dot Net Conference Quiz

## Pregunta 3
```c#
int x = 1;
x = x++;
```

1. **x==1**
2. x==2
3. No existe el operador ++
4. No compila

## Soluci�n � Sergio Gallardo ([@maktub82](https://twitter.com/maktub82))
El [operador ++](https://msdn.microsoft.com/es-es/library/36x43w8w.aspx) es un operador de increment y puede aparecen antes o despu�s del operando. 
Cuando aparece antes del operando (++x) el resultado de la operaci�n es el del operando despu�s de incrementarse. Pero si aparece despu�s del operando (x++), como en nuestro caso, el resultado de la operaci�n es el del operando antes de haberse incrementado.
Por tanto la asignaci�n se hace con el valor original de x, que es 1. As� que la respuesta correcta es x==1.
Sin embargo, si el operador ++ apareciera delante del operando (x = ++x), el resultado de la asignaci�n ser�a el del operando despu�s de haber sido incrementado y por tanto x valdr�a 2.

**Soluci�n:** 1. x==1
