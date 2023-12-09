using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIMT_ForOlder
{
    class userInfo
    {
        private string _id, _gender, _date, _age;
        public string Id 
        {
            get 
            {
                return _id;
            }
            set 
            {
                this._id = value;
            }
        }
        public string Gender
        {
            get
            {
                return _gender;
            }
            set
            {
                this._gender = value;
            }
        }
        public string Date
        {
            get
            {
                return _date;
            }
            set
            {
               this._date = value;
            }
        }
        public string Age
        {
            get
            {
                return _age;
            }
            set
            {
                this._age = value;
            }
        }
    }
}
