using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace ECommerce.Services
{
    public class ReadUserJson : IReadUserJson
    {
        string folderDetails = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot\\{"Data\\User.json"}");

        public async Task<List<T>> ReadUserJsonData<T>()
        {
            var readText = await File.ReadAllTextAsync(folderDetails);

            var objects = new List<T>();

            var serializer = new JsonSerializer();

            using (var stringReader = new StringReader(readText))
            using (var jsonReader = new JsonTextReader(stringReader))
            {
                jsonReader.SupportMultipleContent = true;

                while (jsonReader.Read())
                {
                    T json = serializer.Deserialize<T>(jsonReader);

                    objects.Add(json);
                }
            }

            return objects;
        }
    }
}
