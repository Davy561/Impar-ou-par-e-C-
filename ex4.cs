using System;

class Program {
    static void Main(){
        Console.WriteLine("Digite um número:"); // Solicita ao usuário que digite um número
        int num1 = Convert.ToInt32(Console.ReadLine());//Área onde se deve digitar o número o campo de inserção do número fica ativo enquanto úsuario não digita nada
        if(num1 %2 ==0){
            Console.WriteLine("Esse número é par");
        }else
        Console.WriteLine(num1+" impar");
    }
}
