
    public static bool IsSumInArray(int[] array, int sum)
    {
        // Проверяем, есть ли в массиве число, равное искомой сумме
        if (array.Contains(sum))
            return true;

        // Создаем множество для хранения уже использованных чисел из массива
        HashSet<int> usedNumbers = new HashSet<int>();

        // Перебираем все числа в массиве
        foreach (int number in array)
        {
            // Если это число уже было использовано, пропускаем его
            if (usedNumbers.Contains(number))
                continue;

            // Если это число больше искомой суммы, пропускаем его
            if (number > sum)
                continue;

            // Вычисляем разность между искомой суммой и текущим числом
            int difference = sum - number;

            // Если разность равна 0, значит мы нашли нужные числа
            if (difference == 0)
                return true;

            // Добавляем текущее число в множество использованных чисел
            usedNumbers.Add(number);

            // Ищем оставшиеся числа, которые в сумме дают разность
            bool isSumInArray = IsSumInArray(array, difference);

            // Если такие числа найдены, возвращаем true
            if (isSumInArray)
                return true;
        }

        // Если ничего не найдено, возвращаем false
        return false;
    }




