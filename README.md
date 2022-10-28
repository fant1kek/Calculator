# Описание проекта
Данный проект был написан на языке программирования **C#** и позволяет выполнять простые арифметические операции.

При написании данной программы были соблюдены [Общие требования](https://drive.google.com/file/d/1pG7LePLCTgWDAHcDCO2xN_1V6AvABwZw/view)

![MyCalculator](https://raw.githubusercontent.com/fant1kek/IMG/main/giEnrxcZe3g2BiB_qp2mDhbzBgeHVvjAW9R1RFu-L_w5d9qUYDvPchTq0tnOkN5Ml_wpsipEmwq2hfGR2gw-6HN4.jpg?token=GHSAT0AAAAAAB2PPC3NZZTWTSDYJEDVSV3YY23F67A)

# Описание классов и методов

- **Util**
    - *Calc* - Вызывает методы для арифметических действий и обрабатывает исключения;
    - *Multiply* - Метод умножения;
    - *Divide* - Метод деления;
    - *Sum* - Метод сложения;
    - *Minus* - Метод вычитания;
    - *GetValues* - Производит поиск в строке и разделяет ее на арифметический знак, первый и второй операнды;
- **Form1**
    - *checkExpression* - Выводит результат, если введены больше 2-ух операндов;
    - *checkNum* - Проверяет, является ли число отрицательным и если нужно устанавливает знак "-";
    - *setNum* - Проверяет кол-во введенных символов и устанавливает символ если присутствует место;
    - *setSign* - Устанавливает арифметический знак;

# Инструкция по запуску проекта

1. На вашем компьютере должны быть установлены Ж
    - **Windows** или **macOS**;
    - Visual Studio 2022 или новее;
    - Компонент **«Средства универсальной платформы Windows»** в VS;

2. Клонируйте проек:
```git
git clone https://github.com/fant1kek/Calculator.git
```
3. Откройте **Calculator.sln** и запустите проект;

# Илюстрация работы приложения

![illustration](https://raw.githubusercontent.com/fant1kek/IMG/main/2022-10-28%2003-30-06.gif?token=GHSAT0AAAAAAB2PPC3MJ5KU7PT2ITDGU3JUY23F6HA)

# Инструкция по работе с приложением

Для работы с калькулятором вам необходимо:
1. Выбрать первый операнд;
2. Нажать необходимый математический знак ("**+**", "**-**", "**\***", "**/**");
3. Выбрать второй операнд;
4. Нажать "**=**";

Для воода отрицательного числа - нажать "**+/-**"
Для очистки поля ввода - нажать "**C**";

# Тестирование методов

Все методы были протестированы успешно

![tests](https://raw.githubusercontent.com/fant1kek/IMG/main/pXfn_trI_Hk3NhL8HgukN7HKNwzy_I0TUjTaOJZUoXtZFZn4F621mkhjxnEtXR5q_Z4WBYwdGHRh1IFnfUxCm9rw.jpg?token=GHSAT0AAAAAAB2PPC3MXTWG4A2HRH7OPOTMY23F7OQ)

Для написания юнит-тестов был использован бесплатный инструмент модульного тестирования xUnit
