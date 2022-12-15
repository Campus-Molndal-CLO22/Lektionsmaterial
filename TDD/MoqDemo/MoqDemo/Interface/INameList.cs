namespace MoqDemo.Interface;

public interface INameList
{
    string this[int index] { get; set; }

    int Count { get; }

    void Add(string name);
    void Clear();
    string Find(string text);
}