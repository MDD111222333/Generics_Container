# C_Sharp_Generics_Container

## C#_Generics_Container

### Задание «Контрольная точка №27 — Наследование обобщенных классов»

Вариант 1. Контейнер
1. class Container<T> { protected List<T> items = new(); public virtual void Add(T item) => items.Add(item); public int Count => items.Count; }
2. class StringContainer : Container<string> — фиксирует T = string, добавляет метод PrintAllUpper(), выводящий все строки в верхнем регистре.
3. class CountingContainer<T> : Container<T> — оставляет T открытым, переопределяет Add, чтобы вести отдельный счётчик всех добавлений (TotalAdded), помимо обычного Count.
4. Продемонстрируйте StringContainer с несколькими строками и вызовом PrintAllUpper().
5. Продемонстрируйте CountingContainer<int> и CountingContainer<string> — оба должны корректно считать добавления.

Результаты и проверочные ключи:

<img width="2091" height="369" alt="изображение" src="https://github.com/user-attachments/assets/55bac3ce-2e4f-47f9-9698-72155ecd54e0" />

Результат работы:

<img width="2175" height="501" alt="изображение" src="https://github.com/user-attachments/assets/f5d7902f-2e83-40b1-af0c-a010126b925d" />
