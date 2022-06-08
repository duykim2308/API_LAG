using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class PDA
    {
        public static List<DataObjects.PDA.PDA_TO> GetTO(string id, string stockid)
        {
            List<DataObjects.PDA.PDA_TO> lsItems = DataAccess.PDA.GetTO(id, stockid);
            return lsItems;
        }

        public static List<DataObjects.PDA.PDA_TOHeader> GetTOHeader(string id)
        {
            List<DataObjects.PDA.PDA_TOHeader> lsItems = DataAccess.PDA.GetTOHeader(id);
            return lsItems;
        }

        public static List<DataObjects.PDA.PDA_SO> GetSO(string soid, string stockid)
        {
            List<DataObjects.PDA.PDA_SO> array = DataAccess.PDA.GetSO(soid, stockid);
            return array;
        }

        public static List<DataObjects.PDA.PDA_SOHeader> GetSOHeader(DateTime fd, DateTime td, string stockID)
        {
            List<DataObjects.PDA.PDA_SOHeader> lsItems = DataAccess.PDA.GetSOHeader(fd, td, stockID);
            return lsItems;
        }

        public static List<DataObjects.PDA.PDA_PO> GetPO(string poid, string stockid)
        {
            List<DataObjects.PDA.PDA_PO> array = DataAccess.PDA.GetPO(poid, stockid);
            return array;
        }

        public static List<DataObjects.PDA.PDA_POHeader> GetPOHeader(DateTime fd, DateTime td, string stockID)
        {
            List<DataObjects.PDA.PDA_POHeader> lsItems = DataAccess.PDA.GetPOHeader(fd, td, stockID);
            return lsItems;
        }
        
        public static List<DataObjects.PDA.PDA_Inventory> GetInventory(DateTime d, string stockID)
        {
            List<DataObjects.PDA.PDA_Inventory> lsItems = DataAccess.PDA.GetInventory(d, stockID);
            return lsItems;
        }
        
        public static int CreateNK(DataObjects.PDA.PDA_NK obj)
        {
            return DataAccess.PDA.CreateNK(obj);
        }

        public static int CreateXK(DataObjects.PDA.PDA_XK obj)
        {
            return DataAccess.PDA.CreateXK(obj);
        }

        public static int CreateCK(DataObjects.PDA.PDA_CK obj)
        {
            return DataAccess.PDA.CreateCK(obj);
        }

        public static int CreateKK(List<DataObjects.PDA.PDA_KK> obj)
        {
            return DataAccess.PDA.CreateKK(obj);
        }

        public static int CreateError(List<DataObjects.PDA.PDA_Error> obj)
        {
            return DataAccess.PDA.CreateError(obj);
        }

        public static List<DataObjects.PDA.PDA_Location> GetLocation(string id)
        {
            List<DataObjects.PDA.PDA_Location> lsItems = DataAccess.PDA.GetLocation(id);
            return lsItems;
        }

        public static List<DataObjects.PDA.PDA_User> GetUser(string userid)
        {
            List<DataObjects.PDA.PDA_User> lsItems = DataAccess.PDA.GetUser(userid);
            return lsItems;
        }

        public static List<DataObjects.PDA.PDA_Count> GetCount()
        {
            List<DataObjects.PDA.PDA_Count> lsCount = DataAccess.PDA.GetCount();
            return lsCount;
        }

        public static List<DataObjects.PDA.PDA_Item> GetItem(string itemno)
        {
            List<DataObjects.PDA.PDA_Item> lsItems = DataAccess.PDA.GetItem(itemno);
            return lsItems;
        }
        
        public static List<DataObjects.PDA.PDA_Item> DeleteItem()
        {
            List<DataObjects.PDA.PDA_Item> lsItems = DataAccess.PDA.DeleteItem();
            return lsItems;
        }

        public static List<DataObjects.PDA.PDA_Item> GetItemFilter(int id)
        {
            List<DataObjects.PDA.PDA_Item> lsItems = DataAccess.PDA.GetItemFilter(id);
            return lsItems;
        }

        public static List<DataObjects.PDA.PDA_ItemBarcode> GetItemBarcode(string id)
        {
            return DataAccess.PDA.GetItemBarcode(id);
        }

        public static List<int> DeleteItemBarcode()
        {
            return DataAccess.PDA.DeleteItemBarcode();
        }

        public static List<DataObjects.PDA.PDA_ItemBarcode> GetItemBarcodeFilter(int id)
        {
            return DataAccess.PDA.GetItemBarcodeFilter(id);
        }

        public static int CreateItemBarcode(DataObjects.PDA.PDA_ItemBarcode obj)
        {
            return DataAccess.PDA.CreateItemBarcode(obj);
        }

        public static List<DataObjects.PDA.PDA_Barcode> GetBarcode(string id)
        {
            return DataAccess.PDA.GetBarcode(id);
        }

        public static List<DataObjects.PDA.PDA_Barcode> GetBarcodeFilter(int id)
        {
            return DataAccess.PDA.GetBarcodeFilter(id);
        }
    }
}
