
#region task 1


//int a = 5;
//int b = a;
//b = 10;
//Console.WriteLine(a);
//Console.WriteLine(b);



//int[] arr1 = { 1, 2, 3, };
//int[] arr2 = arr1;
//arr2[0] = 100;

//Console.WriteLine(arr2[0]);
//Console.WriteLine(arr1[0]);



//int n = 5;

//Test(n);

//Console.WriteLine(n);
//static void Test(int n)
//{
//    n = 100;
//    Console.WriteLine(n);
//}




//int[] arr = { 2, 3, 4, 5, };

//Test2(arr);

//Console.WriteLine(arr[0]);


//static void Test2(int[] arr)
//{
//    arr[0] = 200;
//    Console.WriteLine(arr[0]);
//}






//int n = 5;

//Test(ref n);

//Console.WriteLine(n);
//static void Test(ref int n)
//{

//    Console.WriteLine(n);
//}







//int n;

//Test(out n);

//Console.WriteLine(n);
//static void Test(out int n)
//{
//    n = 100;
//    Console.WriteLine(n);
//}




//string name = "Parvin";

//string name2 = name;

//name2 = "Cavid";

//Console.WriteLine(name);
//Console.WriteLine(name2);




//string address = "Ehmedli";

//int result = address.Length;


//Console.WriteLine(result);





//string address = "Ehmedli";

//Console.WriteLine(address.StartsWith("E"));





//string address = "Ehmedli";

//Console.WriteLine(address.EndsWith("i"));








//string address = "Ehmedli";


//if (address.EndsWith("i"))
//{
//    Console.WriteLine("yes");
//}
//else
//{
//    Console.WriteLine("no");
//}





//string address = "Ehmedli";


//if (address.Contains("y"))
//{
//    Console.WriteLine("yes");
//}
//else
//{
//    Console.WriteLine("no");
//}






//string address = "Ehmedli , Azerbaycan , Siyezen";

//var res = address.Split(",");

//foreach (var item in res)
//{
//    Console.WriteLine(item);
//}





//string address = "FARID";

//Console.WriteLine(address.ToLower());




//string address = "farid";

//Console.WriteLine(address.ToUpper());







//string address = "roya";

//var letter = address[0].ToString().ToUpper();

//var arr = address.ToCharArray();

//arr[0] = char.Parse(letter);

//string result = "";

//foreach (var item in arr)
//{
//    result += item;
//}

//Console.WriteLine(result);







//string name = "Jale";

//Console.WriteLine(name.Substring(1).ToUpper());







//string name = "   Jale";
//string name2 = "Jale";

//Console.WriteLine(name.Trim() == name2);







//string name = "Jale";

//Console.WriteLine(name.Replace("J", "T"));











//string name = "Jale";

//if (string.IsNullOrEmpty(name))
//{
//    Console.WriteLine("yes");
//}
//else
//{
//    Console.WriteLine("no");
//}










//string name = " ";

//if (string.IsNullOrWhiteSpace(name))
//{
//    Console.WriteLine("yes");
//}
//else
//{
//    Console.WriteLine("no");
//}

#endregion



#region task2
//OnTheContrary("Cavid");
//static void OnTheContrary(string name)

//{
//    string result = "";
//    for (int i = name.Length - 1; i >= 0; i--)
//    {
//        result += name[i];
//    }

//    Console.WriteLine(result);

//}
#endregion



