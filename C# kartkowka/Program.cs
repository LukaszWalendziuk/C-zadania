using System;

//zad1
int a=0;
int wynik=0;
while(a<40){
    a++;
    wynik += a;
}
Console.WriteLine("Zad1 " + wynik);

//zad2
Console.WriteLine("Zad 2");
int a2=0;
int b2=0;
do{
    b2=4*a2;
    a2++;
    Console.WriteLine(b2);
}while(a2>=1&&a2<=10);

//zad3
Console.WriteLine("Zad 3");
for(int a3 = 0; a3 < 41; a3++){
Console.WriteLine(a3);
}

//zad7
int a7=0;
int wynik7=0;
do{
    a7++;
    wynik7 += a7;
} while(a7<40);
Console.WriteLine("Zad7 "+wynik7);


//zad8
int a8=0;
for(int b=0; b<=40; b++){
    a8 += b;
}
Console.WriteLine("Zad8 "+a8);