using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsontoObject
{
    class Program
    {
        static void Main(string[] args)
        {
            /*use this to get properties: http://json2csharp.com/         */

            string json = @"{  ""kind"": ""fusiontables#sqlresponse"",  ""columns"": [   ""MMM_CLASS""  ],  ""rows"": [   [    ""4""   ]  ] }";
            Console.WriteLine(json);
            JsonObject jsonboj=  JsonConvert.DeserializeObject<JsonObject>(json);
            Console.WriteLine(jsonboj.rows[0][0]); 
        }
    }
}
