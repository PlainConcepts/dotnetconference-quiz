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

## Solución – Sergio Gallardo ([@maktub82](https://twitter.com/maktub82))
El [operador ++](https://msdn.microsoft.com/es-es/library/36x43w8w.aspx) es un operador de increment y puede aparecen antes o después del operando. 
Cuando aparece antes del operando (++x) el resultado de la operación es el del operando después de incrementarse. Pero si aparece después del operando (x++), como en nuestro caso, el resultado de la operación es el del operando antes de haberse incrementado.
Por tanto la asignación se hace con el valor original de x, que es 1. Así que la respuesta correcta es x==1.
Sin embargo, si el operador ++ apareciera delante del operando (x = ++x), el resultado de la asignación sería el del operando después de haber sido incrementado y por tanto x valdría 2.

**Solución:** 1. x==1
