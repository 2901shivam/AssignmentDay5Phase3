// See https://aka.ms/new-console-template for more information
using AssignmentDayFive;




Console.WriteLine("Movie Display portal");

List<Movie> movie = new List<Movie>()
{
    new Movie(){Id=1,Title="Avengeres",Description="Sci-fi"},
    new Movie(){Id=2,Title="Twilight",Description="Thriller"},
    new Movie(){Id=3,Title="Venom",Description="Sci-fi"},
    new Movie(){Id=4,Title="Bhola",Description="Thriller"},
    new Movie(){Id=5,Title="Jumanji",Description="Adventure"}

};




Console.WriteLine("Enter the number 1.Fetching all the movie and 2.For the searching the movie");
int num = int.Parse(Console.ReadLine());
switch (num)
{
    case 1:
        {
            Console.WriteLine("Movie List are as follows");

            foreach (Movie mov in movie)
            {
                Console.WriteLine("Id:" + mov.Id);
                Console.WriteLine("Movie Name" + mov.Title);
                Console.WriteLine("Movie Description" + mov.Description);
            }

            break;
        }
    case 2:
        {
            bool movieFound = false;
            Console.WriteLine("Enter movie name");
            string name = Console.ReadLine();

            try
            {
                foreach (Movie movie1 in movie)
                {
                    if (movie1.Title == name)
                    {
                        Console.WriteLine("Movie Details are as follow");
                        Console.WriteLine("Movie Name" + movie1.Title);
                        Console.WriteLine("Movie Description" + movie1.Description);
                        movieFound = true;
                        break;

                    }

                }
                if (!movieFound)
                {
                    Console.WriteLine("Movie not found");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occured" + ex.Message);
            }

            break;
        }

    default:
        {
            Console.WriteLine("Enter wrong choice");
            break;
        }
}
