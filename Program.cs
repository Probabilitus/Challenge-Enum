using static Enum.Program;

namespace Enum
{
	internal class Program
	{
		public class User
		{
			public string Name { get; set; }
			public string LastName { get; set; }
			public EColor Color { get; set; }
			public User(string name, string lastname, EColor color)
			{
				Name = name;
				LastName = lastname;
				Color = color;
			}
			public enum EColor
			{
				Red = 0,
				Green = 1,
				Blue = 2,
				Yellow = 3,
			}
			public override string ToString()
			{
				return $"Prénom : {Name}\nNom : {LastName}\nCouleur : {Color}";
			}
			public static void Main()
			{
				List<User> users = new List<User>()
				{
					new("Granit", "Marie", EColor.Red),
					new("Emeraude", "Elise", EColor.Green),
					new("Carbone", "Clotilde", EColor.Blue),
					new("Calcium", "Vanessa", EColor.Green),
					new("Neon", "Pierrick", EColor.Yellow),
					new("Bronze", "Aissa", EColor.Red),
					new("Argent", "Soundous", EColor.Red),
					new("Or", "Julie", EColor.Blue)
				};
				/* foreach (var item in users)
				{
					Console.WriteLine(item + "\n");
				}
				*/
				var colorCounts = users.GroupBy(u => u.Color)
							 .ToDictionary(g => g.Key, g => g.Count());

				foreach (var pair in colorCounts)
				{
					Console.WriteLine($"{pair.Key} : {pair.Value} utilisateurs");
				}
			}
		}
	}
}




