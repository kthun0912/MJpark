using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Product
    {
        /// <summary>
        /// 품명 번호
        ///// </summary>
        //private int no;

        /// <summary>
        /// 물품 이름
        /// </summary>
        private string productName;

        /// <summary>
        /// 개수
        /// </summary>
        private int count;

        /// <summary>
        /// 매입 가격
        /// </summary>
        private int puchasePrice;

        /// <summary>
        /// 판매 가격
        /// </summary>
        private int salePrice;

        /// <summary>
        /// 부가세
        /// </summary>
        private int vat;

        /// <summary>
        /// 순이익
        /// </summary>
        private int netProfit;

        /// <summary>
        /// 합계
        /// </summary>
        private int sumPrice;

        /// <summary>
        /// 순이익 합계
        /// </summary>
        private int sumnetProfit;     

        //public int No
        //{
        //    get
        //    {
        //        return no;
        //    }

        //    set
        //    {
        //        no = value;
        //    }
        //}

        public string ProductName
        {
            get
            {
                return productName;
            }

            set
            {
                productName = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }

            set
            {
                count = value;
            }
        }

        public int PuchasePrice
        {
            get
            {
                return puchasePrice;
            }

            set
            {
                puchasePrice = value;
            }
        }

        public int SalePrice
        {
            get
            {
                return salePrice;
            }

            set
            {
                salePrice = value;
            }
        }

        public int VAT
        {
            get
            {
                return vat;
            }

            set
            {
                vat = value;
            }
        }

        public int NetProfit
        {
            get
            {
                return netProfit;
            }

            set
            {
                netProfit = value;
            }
        }

        public int SumPrice
        {
            get
            {
                return sumPrice;
            }

            set
            {
                sumPrice = value;
            }
        }

        public int SumnetProfit
        {
            get
            {
                return sumnetProfit;
            }

            set
            {
                sumnetProfit = value;
            }
        }

        public override string ToString()
        {
            return string.Format("");
        }

    }
}
