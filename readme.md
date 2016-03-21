# Dot Net Conference Quiz

Para cada pregunta, marca con un círculo el resultado correcto que generan las líneas siguientes de código:

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
3. Puede ser cierto
4. No compila

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
3. Nunca se imprime el valor de Value
4. No compila

## Pregunta 3
```c#
int x = 1;
x = x++;
```

1. x==1
2. x==2
3. No existe el operador ++
4. No compila

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
6. FALSE, TRUE, FALSE

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
3. Casi 10
4. No termina
5. 1