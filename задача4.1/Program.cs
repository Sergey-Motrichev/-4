//Напишите цикл, который принимает на вход два числа
//(А и В) и возводит число А в натуральную степень В.
//3,5->245

Console.Write("Введите число:");
int a= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число:");
int b= Convert.ToInt32(Console.ReadLine());

int Pow(int a){
    int result =a;
    for(int i=1;i<b;i++){
        result *= a;
    }
    return result;
}
int result=Pow(a);
System.Console.WriteLine($"{a}->{Pow(a)}");