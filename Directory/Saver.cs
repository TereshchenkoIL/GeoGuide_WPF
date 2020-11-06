using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory
{
    class Saver
    {
        public World Load()
        {
            World world = new World();
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader sr = new StreamReader("World.json"))
            {
                using (JsonTextReader reader = new JsonTextReader(sr))
                {

                    world = (World)serializer.Deserialize(reader, typeof(World));

                }
            }
            return world;
        }

        public void Save( World world)
        {

            JsonSerializer serializer = new JsonSerializer();

            using (StreamWriter writer = new StreamWriter("World.json"))
            {
                using (JsonWriter jw = new JsonTextWriter(writer))
                {
                    serializer.Serialize(jw, world);

                }
            }
        }
    }
}
