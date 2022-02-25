using System.Data;

namespace IotDB_FunctionBlock_Creator
{
    internal class TimeSeries
    {
        //时间序列属性
        private string timeseries;
        private string alias;
        private string storageGroup;
        private string dataType;
        private string encoding;
        private string compression;
        private string tags;
        private string attributes;

        public TimeSeries(string line)
        {
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

        public Vars getVar()
        {
            VARDATATYPE dt = VARDATATYPE.DINT;
            VARTYPE tp = VARTYPE.OUTPUT;
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
            Vars ts = new Vars(timeseries, dt, tp, "", true);
            return ts;
        }

        public override string ToString()
        {
            return timeseries + " : " + alias + "||" + storageGroup + "||" + dataType + "||" + encoding + "||" + compression + "||" + tags + "||" + attributes;
        }

        public DataRow ToDataRow(DataTable table)
        {
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
    }
}
