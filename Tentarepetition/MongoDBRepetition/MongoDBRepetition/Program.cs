// See https://aka.ms/new-console-template for more information
using MongoDB.Bson;
using MongoDB.Driver;

Console.WriteLine("Hello, World!");

// Kör hellre en server i Docker
// Öppnar koppling
var conn = new MongoClient("mongodb://localhost:27017");
// Öppnar databas
var db = conn.GetDatabase("Repetition");

// Hämtar collection
var coll = db.GetCollection<BsonDocument>("Data");

// Skapar ett dokument
//var info = new Info { Data = "Hund" };
//coll.InsertOne(info.ToBsonDocument());

// Alla dokument
var filter = new BsonDocument();
var result = coll.Find(filter);
Print(result);

// Alla dokument sorterade efter data
var sort = Builders<BsonDocument>.Sort.Ascending("Data");
result = coll.Find(filter).Sort(sort);
Print(result);

// Alla dokument med Data = Katt
var filter2 = Builders<BsonDocument>.Filter.Eq("Data", "Katt");
result = coll.Find(filter2);
Print(result);

// Alla dokument där data innehåller A eller a
var filter3 = Builders<BsonDocument>.Filter.Regex("Data", new BsonRegularExpression("a", "i"));
result = coll.Find(filter3);
Print(result);

// Alla dokument där data innehåller A eller a och innehåller inte K
var filter4 = 
    Builders<BsonDocument>.Filter.Regex("Data", new BsonRegularExpression("a", "i")) & 
    !Builders<BsonDocument>.Filter.Regex("Data", new BsonRegularExpression("K", "i"));
result = coll.Find(filter4);
Print(result);

// Uppdatera Hej till Capybara
var filter5 = Builders<BsonDocument>.Filter.Eq("Data", "Hej");
var update = Builders<BsonDocument>.Update.Set("Data", "Capybara");
coll.UpdateOne(filter5, update);

// Alla dokument sorterade efter data
sort = Builders<BsonDocument>.Sort.Ascending("Data");
result = coll.Find(filter).Sort(sort);
Print(result);

// Radera hund
// var filter6 = Builders<BsonDocument>.Filter.Eq("Data", "Hund");
// coll.DeleteOne(filter6);

//// Skapa index för att Data ska vara unik (use CreateIndexModel)
//var index = Builders<BsonDocument>.IndexKeys.Ascending("Data");
//var options = new CreateIndexOptions { Unique = true };
//var model = new CreateIndexModel<BsonDocument>(index, options);
//coll.Indexes.CreateOne(model);

// Find first document using findOne
var filter7 = new BsonDocument();
var result2 = coll.Find(filter7).ToList().FirstOrDefault(); // <--- inte snyggt!!!
Console.WriteLine(result2);


static void Print(IFindFluent<BsonDocument, BsonDocument> result)
{
    foreach (var item in result.ToList())
    {
        Console.WriteLine(item);
    }
    Console.WriteLine("------------");
}
class Info
{
    public string Data { get; set; }
}