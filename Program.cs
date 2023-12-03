using MongoDB.Driver;
namespace MongoConsole
{
	public class Program
	{
		static void Main(string[] args)
		{
			var mongodbUrl = "mongodb+srv://mongocongo:JuXwXo6DUlcB9JMV@cluster0.fp6b2eq.mongodb.net/?retryWrites=true&w=majority";			
			var mongoClient = new MongoClient(mongodbUrl);
			var dbList = mongoClient.ListDatabases().ToList();
			Console.WriteLine("The list of databases on this server is: ");
			foreach (var db in dbList)
			{
				Console.WriteLine(db);
			}
		}
	}
}
