using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MoqDemo;
using MoqDemo.Interface;

namespace MoqDemo.Tests;

[TestClass()]
public class NameListTests
{
    // Skapa en ny List<string>-objekt som kommer att användas i det mockade INameList-objektet
    List<string> names = new List<string> { "Luke Skywalker", "leia Organa", "Obi Wan Kenobi" };
    INameList? nameList = null;
    
    [TestInitialize]
    public void Init()
    {

        // Skapa ett nytt Mock-objekt som kan generera mockade INameList-objekter
        var mock = new Mock<INameList>();

        // Ställ in mock-objektet så att det returnerar det riktiga List<string>-objektet när egenskapen this[int index] åtkomst
        mock.Setup(list => list[It.IsAny<int>()]).Returns((int i) => names[i]);

        // Ställ in mock-objektet så att det returnerar det riktiga antalet objekt i List<string>-objektet när egenskapen Count åtkomst
        mock.Setup(list => list.Count).Returns(() => names.Count);

        // Ställ in mock-objektet så att det använder den riktiga Find-metoden i List<string>-objektet när Find-metoden anropas
        mock.Setup(list => list.Find(It.IsAny<string>())).Returns((string s) => names.Find(n => n.Contains(s)));

        // Ställ in mock-objektet så att det använder den riktiga Add-metoden i List<string>-objektet när Add-metoden anropas
        mock.Setup(list => list.Add(It.IsAny<string>())).Callback((string s) => names.Add(s));

        nameList = mock.Object;
    }
    [TestMethod()]
    public void AddTest()
    {
        // arrange
        var expected1 = nameList.Count + 1;
        var expected2 = "Jar Jar Binks";

        //Act
        nameList.Add("Jar Jar Binks");
        Assert.AreEqual(expected1, nameList.Count);
    }

    public void FindTest()
    {
        // arrange
        var expected1 = nameList.Count + 1;
        var data = "Jar Jar Binks";

        //Act
        nameList.Add(data);

        // Assert
        Assert.AreEqual(data, nameList.Find(data));
    }
}