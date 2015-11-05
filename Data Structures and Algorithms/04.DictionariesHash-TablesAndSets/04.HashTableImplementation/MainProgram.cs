namespace HashTableImplementation
{
    public class MainProgram
    {
        public static void Main(string[] args)
        {
            HashTable<string, int> myHashTable = new HashTable<string, int>();
            myHashTable.Add("one", 1);
            myHashTable.Add("two", 2);
            myHashTable.Add("three", 3);
            myHashTable.Add("four", 4);
            myHashTable.Add("five", 5);
            myHashTable.Add("six", 6);
            myHashTable.Add("seven", 7);
            myHashTable.Add("eight", 8);
            myHashTable.Add("nine", 9);
            myHashTable.Add("ten", 10);
            myHashTable.Add("eleven", 11);
            myHashTable.Add("twelve", 12);
            myHashTable.Add("thirteen", 13);
            myHashTable.Add("fourteen", 14);
            myHashTable.Add("fifteen", 15);
            myHashTable.Add("sixteen", 16);

            var searched = myHashTable.Find("nine");
            myHashTable.Remove("nine");
            myHashTable.Clear();
        }
    }
}
