using System.Collections.Generic;

namespace Interview.Data.Core
{
    public interface IDataProvider
    {
        List<DataDto> ReadAllData();
        List<DataDto> ReadSpecificObject(int id);

        DataDto UpdateObject(DataDto data);
        void InsertObject(DataDto data);
        void RemoveObject(int id);
    }
}
