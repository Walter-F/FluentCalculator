# FluentCalculator

C# библиотека для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам, включающая в себя проверку на то, является ли треугольник прямоугольным, и Unit-тесты.

____

# Задание №1:
1. Может ли переменная быть одновременно `True` и `False`? Определите `someBool` так, чтобы следующее выражение возвращало true: `someBool == true && someBool == false`

# Решение: 

В C# (или любом другом строго типизированном языке программирования) переменная не может быть одновременно true и false. Однако, можно создать условие, которое использует операторы перегрузки, чтобы заставить выражение someBool == true && someBool == false возвращать true. 

Код содержится в папке **BooleanTask.
____

# Задание №2:

Implement a simple calculator with fluent syntax
var FluentCalculator = /* Some magic */;
FluentCalculator should be separated in two, the Values and the Operations, one can call the other, but cannot call one of his own.
A Value can call an Operation, but cannot call a value
FluentCalculator.one.plus FluentCalculator.one.one // error or "undefined", it's up to you.
An Operation can call a Value, but cannot call a operation
FluentCalculator.one.plus.two // this should have a value of 3 FluentCalculator.one.plus.plus // error or "undefined", it's up to you
Pairs of Value and Operation should be stackable to infinity
FluentCalculator.one.plus.two.plus.three.minus.one.minus.two.minus.four // Should be -1
A Value should resolve to a primitive integer
FluentCalculator.one.plus.ten - 10 // Should be 1
Rules:
* Values in FluentCalculator should go from zero to ten.
* Supported Operations are plus, minus, times, dividedBy
* Rules mentioned above
* FluentCalculator should be stackable to infinity
* A Value can only call an Operation
* An Operation can only call a Value
* A Value should be resolvable to a primitive integer, if needed as such

Код решения содержится в папке **FluentCalculator.

В этом коде:
- Каждое число от Zero до Ten представлено как статическое свойство.
- Операции Plus, Minus, Times и DividedBy принимают экземпляр FluentCalculator и выполняют соответствующую операцию.
- Если операция вызывается неправильно (например, две операции подряд), генерируется исключение InvalidOperationException.
- Если происходит деление на ноль, генерируется исключение DivideByZeroException.
- Добавлен метод Operation, который позволяет переключаться между операциями и значениями.
