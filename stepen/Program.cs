/*Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

double stepen (int A, int B) {
    double resualt = Math.Pow(A,B);
    Console.WriteLine(resualt);
    return resualt;
}


int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());

stepen(A,B);