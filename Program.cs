string [] CreatArray(int size){
    string [] array = new string [size];
      for (int i = 0; i < array.Length; i++){
        Console.WriteLine($"Введите текст строки № {i+1}");
        array[i] = Console.ReadLine();
      }
      return array;
    }
string [] ShowArray(string [] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
      }
    return array;
    }
   
int CounterArray(string [] array){
    int count = 0;
      for (int i = 0; i < array.Length; i++){
        if (array[i].Length < 4) count++;
      }
    return count;
    }
string [] ModArray (string [] array, int count){
    string [] newArray = new string [count];
    int index = 0;
      for (int i = 0; i < array.Length; i++){
        if (array[i].Length < 4){
            newArray[index] = array[i];
            index++;
        }
      }
    return newArray;
    }
Console.Write($"Введите количество строк: ");
int size = Convert.ToInt32(Console.ReadLine());
string [] array = CreatArray(size);
Console.WriteLine($"Ваш исходный массив:");
ShowArray(array);  
int count = CounterArray(array);
array = ModArray(array, count);
Console.WriteLine("");
Console.WriteLine($"Ваш массив после обработки:");
ShowArray(array); 