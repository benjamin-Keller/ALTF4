using System.Data;

namespace DAL
{
	class GeneralLibrary
	{
		//This is where we add any Methods that we need
		DataAccessLayer dal = new DataAccessLayer();
		public DataTable PopulateCmbBuilding()
		{

			return dal.PopulateCmbBuilding();
		}

	}
}
