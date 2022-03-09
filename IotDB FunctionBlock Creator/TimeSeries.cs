using System.Data;

namespace IotDB_FunctionBlock_Creator
{
    internal class TimeSeries
    {
        //时间序列属性
        public string timeseries;
        private string alias;
        private string storageGroup;
        private string dataType;
        private string encoding;
        private string compression;
        private string tags;
        private string attributes;

        public TimeSeries(string line)
        {
            //构造函数
            var strs = line.Substring(1).Split('|');
            timeseries = strs[0].Trim();
            alias = strs[1].Trim();
            storageGroup = strs[2].Trim();
            dataType = strs[3].Trim();
            encoding = strs[4].Trim();
            compression = strs[5].Trim();
            tags = strs[6].Trim();
            attributes = strs[7].Trim();
        }

        public Vars getVar(bool output=true)
        {
            //将时间序列转化为变量
            VARDATATYPE dt = VARDATATYPE.DINT;
            VARTYPE tp = VARTYPE.OUTPUT;
            if (!output)
            {
                tp = VARTYPE.INPUT;
            }
            switch (dataType)
            {
                case "INT64":
                    dt = VARDATATYPE.DINT;
                    break;
                case "INT32":
                    dt = VARDATATYPE.DINT;
                    break;
                case "BOOLEAN":
                    dt = VARDATATYPE.BOOL;
                    break;
                case "FLOAT":
                    dt = VARDATATYPE.REAL;
                    break;
                case "DOUBLE":
                    dt = VARDATATYPE.REAL;
                    break;
                case "TEXT":
                    dt = VARDATATYPE.USINT;
                    break;
            }
            Vars ts = new Vars(timeseries.Replace(".", "_"), dt, tp, "", true);
            return ts;
        }

        public override string ToString()
        {
            //将时间序列转化为字符串
            return timeseries + " " + alias + " " + storageGroup + " " + dataType + " " + encoding + " " + compression + " " + tags + " " + attributes;
        }

        public DataRow ToDataRow(DataTable table)
        {
            //将时间序列转化为数据行
            DataRow dr = table.NewRow();
            dr[0] = false;
            dr[1] = timeseries;
            dr[2] = alias;
            dr[3] = storageGroup;
            dr[4] = dataType;
            dr[5] = encoding;
            dr[6] = compression;
            dr[7] = tags;
            dr[8] = attributes;
            return dr;
        }

        public string GetDevice()
        {
            //获取时间序列的设备路径
            string[] ts = timeseries.Split('.');
            string tstmp = "";
            for(int i = 0; i< ts.Length - 1; i++)
            {
                tstmp += ts[i];
                if (i < ts.Length - 2)
                {
                    tstmp += ".";
                }
            }
            return tstmp;
        }

        public string GetMeasurement()
        {
            //获取时间序列的传感器名
            string[] ts = timeseries.Split('.');
            return ts[ts.Length - 1];
        }
    }
}
