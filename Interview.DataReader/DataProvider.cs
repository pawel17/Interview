using Interview.Data.Core;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Interview.DataReader
{
	public class DataProvider : IDataProvider
	{
		private static readonly string DATA_FILE_NAME = "E:\\Programowanie\\Test\\data.json";

		public List<DataDto> ReadAllData()
		{
			return DeserializeObject();
		}

		public List<DataDto> ReadSpecificObject(int id)
		{
			var results = DeserializeObject();
			
			if(results.Count > 1)
			{
				return results.Where(r => r.ApplicationId == id).ToList();
			}
			return new List<DataDto>();
		}

		public void RemoveObject(int id)
		{
			throw new System.NotImplementedException();
		}

		public DataDto UpdateObject(DataDto data)
		{
			throw new System.NotImplementedException();
		}

		public void InsertObject(DataDto data)
		{
			throw new System.NotImplementedException();
		}

		private List<DataDto> DeserializeObject()
		{
			using (StreamReader file = File.OpenText(DATA_FILE_NAME))
			{
				JsonSerializer serializer = new JsonSerializer();
				var results = (List<DataDto>)serializer.Deserialize(file, typeof(List<DataDto>));
				return results;
			}
		}
	}
}
