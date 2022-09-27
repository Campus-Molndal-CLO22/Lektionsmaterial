string[] names = new string[] { "James", "Maria", "Angela" };
// [0] = James
// [1] = Maria
// [2] = Angela

Console.WriteLine(names[(int)People.James]);
enum People
{
    James, 
    Maria, 
    Angela
}
enum PaperHeight
{
    A4 = 297,
    A5 = 210,
    A6 = 148
}
enum PaperWidth
{
    A4 = 210, 
    A5 = 148, 
    A6 = 105
}


