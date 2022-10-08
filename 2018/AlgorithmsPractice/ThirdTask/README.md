# C. Разделите их все
|  |  |
| :---: | :---: |
| Ограничение времени |	1 секунда |
| Ограничение памяти	| 512Mb |
| Ввод	стандартный | ввод или input.txt |
| Вывод	стандартный | вывод или output.txt |

**Решение, проходящее все тесты, будет оценено в 3 балла.**

После работы Оля и Толя решили вместе сходить в тир. После прохождения вводного инструктажа и получения оружия они оказались на позициях для стрельбы, а напротив них находятся *n* мишеней. Все мишени можно считать фигурами, нанесёнными на бесконечную плоскость, при этом каждая мишень является кругом или прямоугольником, мишени могут накладываться и пересекаться произвольным образом.
Перед тем как начать стрельбу, Оля и Толя хотят убедиться, что они смогут однозначно идентифицировать результаты своих выстрелов. Для этого они договорились провести прямую, которая поделит плоскость с мишенями на две части. Однако, чтобы никому не было обидно, они хотят провести прямую таким образом, чтобы каждая мишень была поделена ровно пополам, то есть для каждого круга и каждого прямоугольника должно быть верно, что прямая делит его на две фигуры равной площади.
Когда Оля и Толя наконец закончили прорабатывать все условия разделения мишеней на две части, они начали сомневаться, что провести такую прямую вообще возможно, и просят вас ответить на этот вопрос.

### Формат ввода
В первой строке входных данных записано целое число *n* (*1≤n≤100000*) — количество мишеней. Каждая из последующих n строк содержит целое число *t<sub>i</sub>* (*0≤t<sub>i</sub>≤1*), обозначающее тип мишени. Если *t<sub>i</sub>=0*, то мишень является кругом и далее следуют три целых числа *r<sub>i</sub>*, *x<sub>i</sub>* и *y<sub>i</sub>*, определяющие радиус и координаты центра круга соответственно (*1≤r<sub>i</sub>≤1000*, *−10000≤x<sub>i</sub>,y<sub>i</sub>≤10000*). Если же *t<sub>i</sub>=1*, то мишень является прямоугольником, который затем определяют восемь целых чисел *x<sub>1,i</sub>, y<sub>1,i</sub>, x<sub>2,i</sub>, y<sub>2,i</sub>, x<sub>3,i</sub>, y<sub>3,i</sub>, x<sub>4,i</sub>, y<sub>4,i</sub>* — координаты всех четырёх вершин (*−10000≤x<sub>j,i</sub>,y<sub>j,i</sub>≤10000*), перечисленных в порядке обхода по часовой стрелке или против часовой стрелки. Гарантируется, что данные четыре вершины образуют прямоугольник ненулевой площади.

### Формат вывода
Если существует прямая, которая поделит каждый из имеющихся кругов и прямоугольников на две части одинаковой площади, выведите ***“Yes”***. В противном случае выведите ***“No”***.

#### Пример 1
| Ввод | Вывод |
| :---: | :---: |
| 3 | Yes |
| 0 1 1 1 |  |
| 0 2 2 2 |  |
| 0 3 3 3 |  |

#### Пример 2
| Ввод | Вывод |
| :---: | :---: |
| 1 | Yes |
| 1 0 0 0 1 1 1 1 0 |  |

#### Пример 3
| Ввод | Вывод |
| :---: | :---: |
| 3 | No |
| 1 0 0 0 1 1 1 1 0 |
| 0 10 10 10 |
| 0 1 2 3 |