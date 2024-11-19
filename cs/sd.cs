 //8_1 
  public static class Kata
    {
        public static object[] RemoveEveryOther(object[] arr)
        {
 int newSize = (arr.Length + 1) / 2; 
        object[] result = new object[newSize];

        int j = 0;
        for (int i = 0; i < arr.Length; i += 2)
        {
            result[j++] = arr[i];
        }

        return result;
        }
    }

    // 8_2

    using System;

public static class Kata
{
  public static int Enough(int cap, int on, int wait)
  {
          // Рассчитываем количество людей, которые смогут войти
        int totalPeople = on + wait;
        
        // Если места хватает, возвращаем 0
        if (totalPeople <= cap)
        {
            return 0;
        }
        
        // Если места не хватает, возвращаем количество лишних пассажиров
        return totalPeople - cap;
  }
}

//8_3 
public static class Kata
{
    public static int SquareSum(int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number * number; // Возводим число в квадрат и добавляем к сумме
        }
        return sum;
    }
}

//7_1 
public class Kata
{
  public static double[] Multiples(int m, double n)
  {
   double[] result = new double[m];
        for (int i = 0; i < m; i++)
        {
            result[i] = n * (i + 1); // Вычисляем кратное число
        }
        return result;
  }
}


//7_2
using System;

public static class Kata
{
    public static string Disemvowel(string str)
    {
// Удаляем гласные из строки
        string vowels = "aeiouAEIOU";
        string result = "";

        foreach (char c in str)
        {
            if (!vowels.Contains(c)) // Проверяем, не является ли символ гласной
            {
                result += c; // Добавляем символ в результат
            }
        }

        return result;
    }
}

//7_3 

using System;

public class Kata
{
    public static int SquareDigits(int n)
    {
        string result = "";

        foreach (char digit in n.ToString())
        {
            int num = int.Parse(digit.ToString()); // Преобразуем символ в число
            result += (num * num).ToString(); // Возводим в квадрат и добавляем к строке
        }

        return int.Parse(result); // Преобразуем строку обратно в число
    }
}


//6_3

using System;

public static class Kata 
{
    public static string ExpandedForm(long num) 
    {
 string result = "";
        long placeValue = 1;

        while (num > 0)
        {
            long digit = num % 10; // Получаем последнюю цифру
            if (digit != 0)
            {
                string expandedPart = (digit * placeValue).ToString();
                result = expandedPart + (result == "" ? "" : " + " + result); // Добавляем развернутую часть
            }
            num /= 10; // Убираем последнюю цифру
            placeValue *= 10; // Переходим к следующему разряду
        }

        return result;
    }
}

// 6_2

def expanded_form(num):
    # Разделяем число на целую и дробную части
    integer_part, decimal_part = str(num).split('.')
    
    # Обрабатываем целую часть
    integer_expanded = [
        str(int(digit) * 10**i)
        for i, digit in enumerate(reversed(integer_part))
        if digit != '0'
    ]
    integer_expanded.reverse()  # Приводим порядок в нормальный вид
    
    # Обрабатываем дробную часть
    decimal_expanded = [
        f"{digit}/{10**(i + 1)}"
        for i, digit in enumerate(decimal_part)
        if digit != '0'
    ]
    
    # Объединяем обе части
    expanded = integer_expanded + decimal_expanded
    return " + ".join(expanded)

# Примеры использования
print(expanded_form(807.304))  # Вывод: "800 + 7 + 3/10 + 4/1000"
print(expanded_form(1.24))    # Вывод: "1 + 2/10 + 4/100"
print(expanded_form(7.304))   # Вывод: "7 + 3/10 + 4/1000"
print(expanded_form(0.04))    # Вывод: "4/100"

//6_1

 public class Number {
public static int DigitalRoot(long n)
    {
               while (n >= 10)
        {
            long sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            n = sum;
        }
        return (int)n;
    }
}

// 5_3

using System;

public class TicTacToe
{
  public int IsSolved(int[,] board)
  {
 // Проверяем строки и столбцы
        for (int i = 0; i < 3; i++)
        {
            // Проверка строки
            if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != 0)
            {
                return board[i, 0];
            }

            // Проверка столбца
            if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != 0)
            {
                return board[0, i];
            }
        }

        // Проверяем диагонали
        if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != 0)
        {
            return board[0, 0];
        }

        if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != 0)
        {
            return board[0, 2];
        }

        // Проверяем наличие пустых клеток
        foreach (int cell in board)
        {
            if (cell == 0)
            {
                return -1; // Игра ещё не завершена
            }
        }

        // Если никто не выиграл и пустых клеток нет, то ничья
        return 0;
  }
}

//5_2
class CaesarCipher:
    def __init__(self, shift):
        self.shift = shift

    def encode(self, st):
        return self._shift_string(st, self.shift)

    def decode(self, st):
        return self._shift_string(st, -self.shift)

    def _shift_string(self, st, shift):
        result = []
        for char in st:
            if char.isalpha():  # Проверяем, является ли символ буквой
                base = ord('A') if char.isupper() else ord('a')
                # Вычисляем новую позицию символа в алфавите
                new_char = chr((ord(char) - base + shift) % 26 + base)
                result.append(new_char)
            else:
                result.append(char)  # Оставляем символ без изменений
        return ''.join(result)

//5_1

using System;
using System.Collections.Generic;
using System.Linq;

public class GeneticAlgorithm
{
    private Random random = new Random();

    // Генерация случайной хромосомы
    public string Generate(int length)
    {
        return new string(Enumerable.Range(0, length).Select(_ => random.Next(2) == 0 ? '0' : '1').ToArray());
    }

    // Рулетка для выбора родителя на основе фитнеса
    public string Select(IEnumerable<string> population, IEnumerable<double> fitnesses, double sum = 0)
    {
        var populationArray = population.ToArray();
        var fitnessArray = fitnesses.ToArray();

        sum = fitnessArray.Sum();
        double threshold = random.NextDouble() * sum;
        double cumulative = 0;

        for (int i = 0; i < populationArray.Length; i++)
        {
            cumulative += fitnessArray[i];
            if (cumulative >= threshold)
            {
                return populationArray[i];
            }
        }

        return populationArray.Last();
    }

    // Мутация хромосомы с вероятностью probability
    public string Mutate(string chromosome, double probability)
    {
        return new string(chromosome.Select(bit =>
            random.NextDouble() < probability ? (bit == '0' ? '1' : '0') : bit).ToArray());
    }

    // Кроссовер между двумя хромосомами
    public IEnumerable<string> Crossover(string chromosome1, string chromosome2)
    {
        if (random.NextDouble() < 0.6) // 60% вероятность кроссовера
        {
            int crossoverPoint = random.Next(1, chromosome1.Length); // Точка разреза
            return new string[]
            {
                chromosome1.Substring(0, crossoverPoint) + chromosome2.Substring(crossoverPoint),
                chromosome2.Substring(0, crossoverPoint) + chromosome1.Substring(crossoverPoint)
            };
        }
        return new string[] { chromosome1, chromosome2 };
    }

    // Главный метод выполнения алгоритма
    public string Run(Func<string, double> fitness, int length, double p_c, double p_m, int iterations = 100)
    {
        int populationSize = 100; // Размер популяции
        var population = Enumerable.Range(0, populationSize).Select(_ => Generate(length)).ToList();

        for (int iter = 0; iter < iterations; iter++)
        {
            // Оцениваем фитнес текущей популяции
            var fitnesses = population.Select(fitness).ToList();
            var newPopulation = new List<string>();

            while (newPopulation.Count < populationSize)
            {
                // Выбираем двух родителей
                string parent1 = Select(population, fitnesses);
                string parent2 = Select(population, fitnesses);

                // Выполняем кроссовер
                var children = Crossover(parent1, parent2).ToArray();

                // Добавляем детей с мутацией
                newPopulation.Add(Mutate(children[0], p_m));
                newPopulation.Add(Mutate(children[1], p_m));
            }

            // Обновляем популяцию
            population = newPopulation.Take(populationSize).ToList();
        }

        // Возвращаем самую подходящую хромосому
        return population.OrderByDescending(fitness).First();
    }
}

