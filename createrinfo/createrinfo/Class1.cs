using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createrinfo
{
    public class main
    {
        public String createrinfo()
        {
            string fio = "Колесников Артем Максимович";
            string group = "КС-20";
            string project = "Лабораторная работа 4";
            string result = fio + ", " + group + ", " + project;
            return result;
        }

    }
}
