using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {

        public SuccessDataResult(T data, string message): base(data,true,message)
        {
            Data = data;
            message = message;
            Success = true;
        }
        public SuccessDataResult(T data): base(data,true)
        {
            Data = data;
            Success = true;
        }
        public SuccessDataResult(string message): base(default,true,message)
        {
            message = message;
            Success = true;
        }
        public SuccessDataResult():base(default,true)
        {
            Success = true;
        }
        public T Data { get; }

        public bool Success { get; }

        public string Message { get; }
    }
}
