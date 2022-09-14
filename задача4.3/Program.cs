//Напишите программу,которая задает массив из 8 элементов
//и выводит их на экран.

int[] GetArray(){
    int[] result=new int[8];
    for(int i=0;i<result.Length;i++){
        result[i] = new Random().Next(20);
    }    
    return result;
}
void PrintArray(int[]arr){
    for(int i=0;i<arr.Length;i++){
        Console.Write(arr[i]+",");    
    }
    System.Console.WriteLine();
}
PrintArray(GetArray());
