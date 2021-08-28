using System;
using System.Collections.Generic;
using nsILogLevel;

namespace nsLogData
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

        public List<string> GetLogData()
        {
            _dataList.Add(GetLogLevelData(_info));
            _dataList.Add(GetLogLevelData(_warning));
            _dataList.Add(GetLogLevelData(_error));
            return _dataList;
        }

        private string GetLogLevelData(ILogLevel logLevel)
        {
            return logLevel.GetStatus() + ": " + logLevel.GetMessage();
        }

        private ILogLevel _info;
        private ILogLevel _warning;
        private ILogLevel _error;
        private List<string> _dataList;
    }
}
