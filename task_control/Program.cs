// // // ввод 3 строк
// // массив из 3 строк
// // подсчет в масиве колличество симоволов
// // создать массив с кол-вом символов мень 3


string[] stringArray = new string[3];
int j = 0; 
int size = 0;
for(int i = 0; i < stringArray.Length; i++)
{
   stringArray[i] = Console.ReadLine();
}

foreach (string el in stringArray)
{
 if (el.Length <= 3 )
 {
   size++;
 }
}

string[] newStringArray = new string[size];

   for (int i =0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <=3)
        {
            
        newStringArray [j] = stringArray[i];
        j++;
        
        }
        
    }
Console.WriteLine("\nМассив: {0}",String.Join(" ",newStringArray));



// Console.Write(size);




