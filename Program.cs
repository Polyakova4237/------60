/*
Задача 60.Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int [,,] array = GenerateArray3D();

PrintArray (array);

int [,,] GenerateArray3D()
{
    int [,,] result = new int[2, 2, 2];

    HashSet <int> hashSet = new HashSet <int>();

    

    Random random = new Random();

    for (var i = 0; i < result.GetLenght(0); i++)
    {
        for (var j = 0; j < result.GetLenght(1); j++)
        {
            for (var k = 0; k < result.GetLenght(2); k++)
            {
                while (true)
                {
                    
        
                int number = random.Next(10,100);
                bool isExists = hashSet.TryGetValue(number,out int _);

                if (!isExists){
                    result[i,j,k]= number;
                    hashSet.Add(number);
                    break;
                }
                
                }
            }
        }
    }

    return result;
  
}

void PrintArray(int[,,] array)
{
       for (var i = 0; i < array.GetLenght(0); i++)
    {
        for (var j = 0; j < array.GetLenght(1); j++)
        {
            for (var k = 0; k < array.GetLenght(2); k++)
            {
                Console.Write($"{array[i,j,k]}({i},{j},{k} ");
                            
            }
        }
    } 
}