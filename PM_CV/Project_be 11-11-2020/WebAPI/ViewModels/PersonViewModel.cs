using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.ViewModels
{
    public class PersonViewModel:BaseViewModel
    {
        private PersonInfo _personInfo;
        public PersonViewModel()
        {
            if (_personInfo == null)
                _personInfo = new PersonInfo();
        }

        public PersonInfo PersonInfo 
        {
            get { return _personInfo; }
            set { _personInfo = value; }
        } 
    }
}
