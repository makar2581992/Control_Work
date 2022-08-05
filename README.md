# **Задача :**

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


## **Решение :**

1. Графическое представление задачи в виде блок-схемы находится в папке ***Block-shem***, в файле с расширением jpg.


2. Описание алгоритма решения:

    Объявляется два массива одинаковой длины. Затем метод, в котором цикл соразмерный длине массива, внутри цикла проверка условия ( <=3 ) - если условие выполняется, то элемент первого массива заносится в переменную count - элемент второго массива. Переменная count необходима чтобы поочередно переносить элементы из первого массива во второй. После присвоения увеличивается переменная count на 1 и возвращается к циклу for в котором i увеличивается на 1. И таким образом проверяется до конца.

3. Код программы находится по пути **Task/Program.cs**