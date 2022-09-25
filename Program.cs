int[] array1 = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
string[] array2 = {"Tim", "Martin", "Nikki", "Sara"};
bool[] array3 = new bool[10];
Console.WriteLine("****************************************************");
Console.WriteLine(" ");
for(int i = 0; i < array3.Length; i++){
    if(i % 2 == 0 || i == 0){
        array3[i] = true;
    }else{
        array3[i] = false;
    }
    Console.WriteLine(array3[i]);
}
Console.WriteLine(" ");
Console.WriteLine("****************************************************");
Console.WriteLine(" ");

List<string> iceC = new List<string>();
iceC.Add("vanilla");
iceC.Add("chocolate");
iceC.Add("mint");
iceC.Add("cookie dough");
iceC.Add("cookies n' cream");
Console.WriteLine(iceC.Count);
Console.WriteLine(iceC[2]);
iceC.RemoveAt(2);
Console.WriteLine(iceC.Count);
Console.WriteLine(" ");

Dictionary<string, string> dict = new Dictionary<string, string>();
Random rand = new Random();
Console.WriteLine("****************************************************");
for(int i = 0; i < 4; i++){
    int randFlav = rand.Next(0, 4);
    Console.WriteLine(" ");
    Console.WriteLine($"The random flavor is {iceC[randFlav]}!");
    dict.Add(array2[i], iceC[randFlav]);
    Console.WriteLine($"{array2[i]}'s favorite ice cream flavor is {dict[array2[i]]}!");
    Console.WriteLine("____________________________________________________");    
}
Console.WriteLine(" ");
Console.WriteLine("Dictionary Key-Value Pair Output");
Console.WriteLine("____________________________________________________");
foreach (KeyValuePair<string,string> entry in dict){
    Console.WriteLine(" ");
    if(entry.Key == array2[0]){
        Console.WriteLine($"{{ \n\"{entry.Key}\" : \"{entry.Value}\",");

    }else if(entry.Key != array2[3]){
        Console.WriteLine($"\"{entry.Key}\" : \"{entry.Value}\",");

    }else{
        Console.WriteLine($"\"{entry.Key}\" : \"{entry.Value}\" \n}}");
    }
}
Console.WriteLine(" ");
Console.WriteLine("****************************************************");

