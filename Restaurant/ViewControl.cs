using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class ViewControl
    {
        PMJModel pmjModel;


        public ViewControl()
        {
            pmjModel = new PMJModel();
        }

        public List<string[]> getAllProduct()
        {
            List<string[]> MainViewString = new List<string[]>();
            foreach (KeyValuePair<int, Product> item in pmjModel.getProductDicList())
            {
                string[] ProductString = new string[8];
                ProductString[0] = item.Key.ToString();
                ProductString[1] = item.Value.ProductName;
                ProductString[2] = item.Value.Count.ToString();
                ProductString[3] = item.Value.PuchasePrice.ToString();
                ProductString[4] = item.Value.SalePrice.ToString();
                ProductString[5] = item.Value.VAT.ToString();
                ProductString[6] = item.Value.NetProfit.ToString();
                ProductString[7] = item.Value.SumPrice.ToString();
                MainViewString.Add(ProductString);
            }
            return MainViewString;
        }

        public bool AddProduct(string name, int count,int puchaseprice, int saleprice)
        {
            return pmjModel.AddProductDicList(name,count,puchaseprice,saleprice);            
        }
    }
}
