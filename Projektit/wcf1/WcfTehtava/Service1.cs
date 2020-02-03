using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfTehtava
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(string value)
        {
            return string.Format("You said: {0}", value);
        }

        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}
        /// <summary>
        /// laskee annettujen lukujen tuoln
        /// </summary>
        /// <param name="luku">eka kerrottava</param>
        /// <param name="toinen"></param>
        /// <returns></returns>
        public int Tulo(int luku, int toinen)
        {
            return luku * toinen;
        }
    }
}
