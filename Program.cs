int GetNegativeSum(int[] array)
{
  int sum = 0;

  for (int i = 0; i < array.Length; i++) if (array[i] < 0) sum += array[i];
  return sum;
}

//Task1. Замена положительных на отрицательные и наоборот.

int[] ChangeArray(int[] array)
{
  for (i = 0; i < array.Length; i++)
  {
    array[i] *= (-1);
  }
  return array;
}
//Task2. Определить, присутствует ли заданное число в массиве.

bool IsNumberIn(int[] array, int n)
{
  for (int i = 0; i < array.Length; i++) if (array[i] == n) return true;
  return false;
};

//Task3. Задать одномерный массив из m случайных чисел. Найти количество элементов массива, 
//значения которых лежат в отрезке [a,b].

int HowManyNumbers(int[] array, int a, int b)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++) if (array[i] >= a & array[i] <= b) count++;
  return count;
};