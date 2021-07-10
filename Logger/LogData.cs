using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    class LogData
    {
        public LogData()
        {
            this._info = new Info();
            this._warning = new Warning();
            this._error = new Error();
            this._dataList = new List<string>();
        }

        public List<string> GetLogdata()
        {
            _dataList.Add(_info.GetStatus() +": "+ _info.GetMessage());
            _dataList.Add(_warning.GetStatus() +": "+ _warning.GetMessage());
            _dataList.Add(_error.GetStatus() +": "+ _error.GetMessage());
            return _dataList;
        }

        private ILogLevel _info;
        private ILogLevel _warning;
        private ILogLevel _error;
        private List<string> _dataList;
    }
}
