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








