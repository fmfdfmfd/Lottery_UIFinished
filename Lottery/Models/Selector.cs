using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottery
{
    class Selector
    {
        //private List<string> resultNumList = new List<string>();    //不对外操作, 因此使用字段

        private Random random = new Random();   //不对外操作, 因此使用字段

        private List<string> redNumRiver = new List<string>
        {
            "01","02","03","04","05","06","07","08","09","10",
            "11","12","13","14","15","16","17","18","19","20",
            "21","22","23","24","25","26","27","28","29","30",
            "31","32","33"
        };

        private List<string> blueNumRiver = new List<string>
        {
            "01","02","03","04","05","06","07","08","09","10",
            "11","12","13","14","15","16"
        };

        public Selector() { }

        public List<string> CreateRandomNumList()
        {
            List<string> resultNumList = new List<string>();
            //获取红球
            while ( true )
            {
                if ( resultNumList.Count >= 6 )
                    break;
                else
                {
                    string randomNum = redNumRiver[random.Next(33)];
                    if ( resultNumList.Contains(randomNum) )
                        continue;
                    else
                        resultNumList.Add(randomNum);
                }
            }
            //获取蓝球
            resultNumList.Add(blueNumRiver[random.Next(16)]);
            return resultNumList;
        }
    }
}
