internal class Program
{
    private static void Main(string[] args)
    {
        string[] strArray1 = { "hello", "Vasiliy", "John", "Ann", "Go" };
        string[] strArray2 = { "python", "c#", "gava", "c++", "R" };

        int numSymbols = 3;

        int CountItems(string[] srtArr)
        {
            int count = 0;

            for (int i = 0; i < srtArr.Length; i++)
            {
                if (srtArr[i].Length <= numSymbols) count++;
            }

            return count;
        }

        string[] NewArray(string[] strArr)
        {
            int lenghtNewArr = CountItems(strArr);
            string[] newArr = new string[lenghtNewArr];

            foreach (string str in strArr)
            {
                int i = 0;
                while (i < lenghtNewArr)
                {
                    if (str.Length <= numSymbols)
                    {
                        newArr[i] = str;
                        i++;
                    }
                }
            }
            Console.WriteLine(newArr);
            return newArr;
        }

        string[] newArray = NewArray(strArray1);
    }
}

//Console.WriteLine(newArray);