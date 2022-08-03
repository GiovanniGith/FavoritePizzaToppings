// A pizza chain wants to know which topping combinations are most popular for Build Your Own pizzas.

//Given the sample of orders at [http://files.olo.com/pizzas.json](http://files.olo.com/pizzas.json), write an application
//(in C# or JavaScript) to output the top 20 most frequently ordered pizza configurations, listing the toppings for each along with the number of times that pizza configuration has been
//ordered.

//Check this link [to read a JSON file] (https://www.newtonsoft.com/json/help/html/DeserializeWithJsonSerializerFromFile.html)
//in c#. You'll need to install the Newtonsoft.Json nuget package, and create a class that represents the pizzas.


// read file into a string and deserialize JSON to a type
/*Movie movie1 = JsonConvert.DeserializeObject<Movie>(File.ReadAllText(@"c:\movie.json"));

// deserialize JSON directly from a file
using (StreamReader file = File.OpenText(@"c:\movie.json"))
{
    JsonSerializer serializer = new JsonSerializer();
    Movie movie2 = (Movie)serializer.Deserialize(file, typeof(Movie));
}
*/
using FavoritePizzaToppings;
using Newtonsoft.Json;


List<Pizza> pizzas = JsonConvert.DeserializeObject<List<Pizza>>(File.ReadAllText("C:\\Users\\gbara\\source\\repos\\FavoritePizzaToppings\\FavoritePizzaToppings\\pizzas.json"));



Console.ReadLine();