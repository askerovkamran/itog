Console.Write("Введите количество элементов массива: ");
int size  = int.Parse(Console.ReadLine());
Console.Clear();
string[] array1 = new string[size];




for (int i = 0; i < size; i++){
	Console.Write("Введите данные: ");
    string result = Console.ReadLine();
	array1[i] = result; 
Console.Clear(); 
}




Console.WriteLine();
Console.Write("Массив: [");
Console.Write(string.Join(",", array1));
Console.Write("]");
Console.Clear();

int count = 0;
int m = 3;

for (int i = 0; i < array1.Length; i++){
	if(array1[i].Length <= m){
		count++;
	}   
}
Console.WriteLine();
Console.Write("Результат: [");
string[] array2 = new string[count];
int j = 0;
for (int i = 0; i < array1.Length; i++){
    if(array1[i].Length <= m){
        array2[j] = array1[i];
        Console.Write(array2[j] + ",");
        j++;
    }
}