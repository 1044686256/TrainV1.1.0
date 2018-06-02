using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace TrainV1._1._0
{
    class LoadPictrue
    {
        static string images = "";
        static public string  FindPictrueName()
        {
            int _iPictureShowCount = 0;
            Pictures res = new Pictures();
            PropertyInfo[] peoperInfo = res.GetType().GetProperties(BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Instance);
            string[] image = new string[peoperInfo.Count()];
            foreach (PropertyInfo pro in peoperInfo)
            {
                image[_iPictureShowCount] = pro.Name;
                images += pro.Name;
                _iPictureShowCount++;
            }
            return images;
        }
    }
}
