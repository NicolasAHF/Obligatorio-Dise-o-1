using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SocialNetwork
{
    public class Status : Contents
    {
        private string _status;

        const int MIN_LENGTH_FOR_VALID_STATUS = 10;
        const int MAX_LENGTH_FOR_VALID_STATUS = 160;

        public string ElStatus
        {
            get { return _status; }
            set => SetStatus(value);
        }


        public Status()
        {
            
        }
        public Status(string status)
        {
            this.SetStatus(status);
        }

        public void SetStatus(String status)
        {
            ValidMinLengthStatus(status);
            ValidMaxLengthStatus(status);
            this._status = status;
        }

        private void ValidMinLengthStatus(string status)
        {
            if (status.Length < MIN_LENGTH_FOR_VALID_STATUS)
            {
                throw new InvalidOperationException("La frace de estado no alcanza el largo minimo");
            }
        }
        private void ValidMaxLengthStatus(string status)
        {
            if (status.Length > MAX_LENGTH_FOR_VALID_STATUS)
            {
                throw new InvalidOperationException("La frace de estado supera el largo máximo");
            }
        }
    }
}
