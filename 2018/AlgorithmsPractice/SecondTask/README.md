﻿B. Фактор палиндромности
Ограничение времени	1 секунда
Ограничение памяти	512Mb
Ввод	стандартный ввод или input.txt
Вывод	стандартный вывод или output.txt
Решение, проходящее все тесты, будет оценено в 3 балла.

Аркадий — большой фанат использования машинного обучения в любой задаче. Он верит в безграничную силу волшебства этой популярной молодой науки. Именно поэтому Аркадий постоянно постоянно придумывает всё новые и новые факторы, которые можно вычислить для различных объектов.
Напомним, палиндромом называется строка, которая одинаково читается от начала к концу и от конца к началу. Для каждой строки в своей базе данных Аркадий хочет найти самую короткую её подстроку, состоящую хотя бы из двух символов и являющуюся палиндромом. Если таких подстрок несколько, Аркадий хочет выбрать лексикографически минимальную.

Формат ввода
В единственной строке входных данных записана одна строка из базы Аркадия — непустая последовательность строчных букв английского алфавита. Длина строки составляет не менее 
2
 и не превосходит 
2
0
0
0
0
0
 символов.
Формат вывода
Выведите минимальную по длине подстроку строки из входных данных, состоящую хотя бы из двух символов и являющуюся палиндромом. Если такой подстроки нет, то выведите 
−
1
. Напомним, что среди всех таких строк Аркадий хочет найти лексикографически минимальную.
Пример 1
Ввод	Вывод
abac
aba
Пример 2
Ввод	Вывод
yandex
-1
Примечания
Говорят, что строка 
a
=
a
1
a
2
…
a
n
 лексикографически меньше строки 
b
=
b
1
b
2
…
b
m
 если верно одно из двух условий:
либо 
n
<
m
 и 
a
1
=
b
1
,
a
2
=
b
2
,
…
,
a
n
=
b
n
, то есть первая строка является префиксом второй;
либо есть такая позиция 
1
≤
i
≤
min
(
n
,
m
)
, что 
a
1
=
b
1
,
a
2
=
b
2
…
,
a
i
−
1
=
b
i
−
1
 и 
a
i
<
b
i
, то есть, в первой позиции, в которой строки различаются, в первой строке стоит меньшая буква.