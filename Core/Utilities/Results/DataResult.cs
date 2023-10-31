using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        public DataResult(T data,bool success, string message):base(success,message)
        {
            Data = data;
        }
        public DataResult(T data, bool success):base(success)
        {
            Data = data;
        }
        public T Data {  get; }
    }
}
//class oldugu için dataresult'a diyoruz ki sen bir resultsun
/*
 * sen aslında result'ın içindeki yapıyı içeriyorsun haberin olsun diyoruz
 * o da diyor ki ama o adamın constructorları var diyor onları bir implemente et diyor
 */