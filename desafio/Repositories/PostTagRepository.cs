using System.Runtime.CompilerServices;
using Blog.Models;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Blog.Repositories
{
    public class PostTagRepository : Repository<PostTag>
    {
        private readonly SqlConnection _connection;

        public PostTagRepository(SqlConnection connection) : base(connection)
            => _connection = connection;

        public List<Post> ListPostTag()
        {
            var query = @"
                SELECT
                    [Post].*,
                    [Tag].*
                FROM
                    [Post]
                    LEFT JOIN [PostTag] ON [PostTag].[PostId] = [Post].[Id]
                    LEFT JOIN [Tag] ON [PostTag].[TagId] = [Tag].[Id]";

            var posts = new List<Post>();

            var items = _connection.Query<Post, Tag, Post>(
                query,
                (post, tag) =>
                {
                    var pst = posts.FirstOrDefault(x => x.Id == post.Id);
                    if (pst == null)
                    {
                        pst = post;
                        if (tag is not null)
                            pst.Tags.Add(tag);

                        posts.Add(pst);

                    }
                    else
                        pst.Tags.Add(tag);
                    return post;
                }, splitOn: "Id");

            return posts;
        }
    }
}