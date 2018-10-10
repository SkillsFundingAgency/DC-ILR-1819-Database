using ESFA.DC.ILR1819.DataStore.EF.Interfaces;

namespace ESFA.DC.ILR1819.DataStore.EF
{
    public partial class ILR1819_DataStoreEntities : IILR1819_DataStoreEntities
    {
        public ILR1819_DataStoreEntities(string connectionString)
            : base(connectionString)
        {
            
        }
    }
}