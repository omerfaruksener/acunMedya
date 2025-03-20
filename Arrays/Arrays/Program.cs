int[] arr= new int[5];
for(int i=0; i<5; i++)
{
    int a=int.Parse(Console.ReadLine()) ;
    arr[i] = a;
}
int toplam = 0;
for (int i = 0; i < 5; i++)
{
     toplam += arr[i];
    Console.WriteLine(toplam);
    if(i == 4)
    {
        Console.WriteLine(toplam / 5);
    }
}
