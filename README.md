# Описание проекта
Данный проект был написан на языке программирования **C#** и позволяет выполнять простые арифметические операции.

При написании данной программы были соблюдены [Общие требования](https://drive.google.com/file/d/1pG7LePLCTgWDAHcDCO2xN_1V6AvABwZw/view)

![MyCalculator](https://user-images.githubusercontent.com/82901435/198687513-578f1132-ae1d-4129-89cd-448605d4f644.jpg)


# Описание классов и методов

- **Util**
    - *Calc* - Вызывает методы для арифметических действий и обрабатывает исключения;
    - *Multiply* - Метод умножения;
    - *Divide* - Метод деления;
    - *Sum* - Метод сложения;
    - *Minus* - Метод вычитания;
    - *GetValues* - Производит поиск в строке и разделяет ее на арифметический знак, первый и второй операнды;
- **Form1**
    - *buttonZero_Click - buttonNine_Click* - Обработка нажатий на цифры;
    - *buttonClear_Click* - Очистка поля ввода;
    - *buttonPlusMinus_Click* - Делает число отрицательным\положительным;
    - *buttonSum_Click, buttonMinus_Click, buttonMultiply_Click, buttonDivide_Click* - Обработка нажатий на кнопки с арифметическими действиями;
    - *buttonEquals_Click* - Получения результат введенного выражения;
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

![illustration](https://user-images.githubusercontent.com/82901435/198687661-0a905402-acac-4c1c-8ddd-06ca24d8e0a2.gif)

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

![tests](https://user-images.githubusercontent.com/82901435/198687748-5133217e-977f-4fc4-9a36-01b88d6784f2.jpg)


Для написания юнит-тестов был использован бесплатный инструмент модульного тестирования xUnit
