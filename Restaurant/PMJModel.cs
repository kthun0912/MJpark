using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class PMJModel
    {
        private Dictionary<int,Product> ProductDicList;

        private const int MAXDATE = 1024;
        private const int VAT = 10;
        /// <summary>
        /// 생성자
        /// </summary>
        public PMJModel()
        {
            ProductDicList = new Dictionary<int, Product>();
        }

        public Dictionary<int, Product> getProductDicList()
        {
            return ProductDicList;
        }

        public void ClearProdctDicList()
        {
            ProductDicList.Clear();
        }

        public int getIndex()
        {
            int index = -1;
            for (int i = 1; i < MAXDATE; i++)
            {
                if(ProductDicList.ContainsKey(i) != true)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        public bool AddProductDicList(int index, Product pd)
        {
            bool result;

            if (ProductDicList.ContainsKey(index) == true)
            {
                result = false;
            }
            else
            {
                ProductDicList.Add(index, pd);
                result = true;
            }
            return result;
        }

        public bool AddProductDic(int index, string productname, int puchasePrice, int salePrice,
            int vat, int netprofit, int sumprice)
        {
            bool result;
            if (ProductDicList.ContainsKey(index) == true)
            {
                result = false;
            }
            else
            {
                Product pd = new Product();
                pd.ProductName = productname;
                pd.PuchasePrice = puchasePrice;
                pd.SalePrice = salePrice;
                pd.VAT = vat;
                pd.NetProfit = netprofit;
                pd.SumPrice = sumprice;
                ProductDicList.Add(index, pd);
                result = true;
            }
            return result;

        }

        public bool AddProductDicList(string name, int count, int puchaseprice, int saleprice)
        {
            bool result;
            int index = getIndex();
            if (ProductDicList.ContainsKey(index) == true)
            {
                result = false;
            }
            else
            {
                int vatSale = (int)VATcalculation(saleprice);
                int netprofit = saleprice - vatSale;
                int sumprice = netprofit * count;
                Product pd = new Product();
                pd.ProductName = name;
                pd.Count = count;
                pd.PuchasePrice = puchaseprice;
                pd.SalePrice = saleprice;
                pd.VAT = vatSale;
                pd.NetProfit = netprofit;
                pd.SumPrice = sumprice;
                ProductDicList.Add(index, pd);
                result = true;
            }
            return result;
        }

        public double VATcalculation(int salePrice)
        {
            double VatWithSale = salePrice / VAT;
            return VatWithSale;
        }
    }
}
