using GraphQLApi.Model;
using GraphQLApi.GraphQL;

namespace GraphQLApi.GraphQL
{
    public class Mutation
    {
        public Book AddBook(int id,string title,string author) {
            var book = new Book
            {
                Id = id,
                Title = title,
                Author = author
            };

            Query._books.Add(book);

            return book;
        }
    }
}
